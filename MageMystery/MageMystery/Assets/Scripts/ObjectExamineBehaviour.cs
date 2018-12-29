using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.AI;
using UnityEngine.Events;

public class ObjectExamineBehaviour : MonoBehaviour {

    public enum ACTIONS { NONE, DEFAULT, ELEMENT,  }


    private ACTIONS action = ACTIONS.NONE;
    private Collider myCollider;
    private bool trigger = false;

    public Fungus.Flowchart myFlowchart;
    public NavMeshAgent player;



    private void Start()
    {
    }


    private void Update()
    {
        if (myFlowchart.HasExecutingBlocks())
        {
            player.enabled = false;
        } else
            player.enabled = true;

        Debug.Log(action.ToString());

        if (trigger && action != ACTIONS.NONE)
        {
            switch (action)
            {
                case ACTIONS.ELEMENT:
                    {
                        myFlowchart.ExecuteBlock("Element");

                        if (myFlowchart.GetBooleanVariable("ElementRead"))
                        {
                            myFlowchart.ExecuteBlock("Element Read");
                        }

                        break; //se a acção for ESSENCIAL, adicionar a uma variável global para ser lida depois!
                    }

                case ACTIONS.DEFAULT:
                    {
                        myFlowchart.ExecuteBlock("Default");
                        break;
                    }

            }

            action = ACTIONS.NONE;
        }
    }
    
        

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = false;
        }
    }

    private void OnMouseDown()
    {


        if (Input.GetKey(KeyCode.A))
        {
            action = ACTIONS.ELEMENT;
        } else
        {
            action = ACTIONS.DEFAULT;
        }


    }
}

