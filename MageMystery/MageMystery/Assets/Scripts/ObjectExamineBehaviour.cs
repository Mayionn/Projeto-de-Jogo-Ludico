using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExamineBehaviour : MonoBehaviour {

    public enum ACTIONS { NONE, DESTROY }

    public bool trigger = false;
    public GameObject example;

    private ACTIONS action = ACTIONS.NONE;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // trigger = true;

            if (action != ACTIONS.NONE)
            {
                Destroy(example);
                action = ACTIONS.NONE;
            }

            Debug.Log("Made a Collission");
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

        action = ACTIONS.DESTROY;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
