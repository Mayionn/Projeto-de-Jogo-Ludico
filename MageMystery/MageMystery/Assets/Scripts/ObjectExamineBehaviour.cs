using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectExamineBehaviour : MonoBehaviour {

    public enum ACTIONS { NONE, DESTROY, RED }

    public bool trigger = false;
    public GameObject example;
    public Material material;

    private ACTIONS action = ACTIONS.NONE;


    // Use this for initialization
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // trigger = true;

            if (action == ACTIONS.DESTROY)
            {
                Destroy(example);
                action = ACTIONS.NONE;
            }

            Debug.Log("Made a Collission");

            if (action == ACTIONS.RED)
            {
                material.color = Color.red;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = false;
            Debug.Log("Left");
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");

        //if (trigger == true)
        //{
        //    Destroy(example);

        //}

        

        if (Input.GetKey(KeyCode.A))
        {
            action = ACTIONS.RED;
        } else
        {
            action = ACTIONS.DESTROY;
        }
    }




	

}
