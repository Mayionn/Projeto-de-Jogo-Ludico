using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.AI;
using UnityEngine.Events;

public class ObjectExamineBehaviour : MonoBehaviour {

    


    private ACTIONS action = ACTIONS.NONE;
    private Collider myCollider;
    private bool trigger = false;
    Renderer myRenderer;
    private Shader outline;
    private Shader noLine;

    public enum ACTIONS { NONE, DEFAULT, ELEMENT, DEATH, MIND, MATTER, TIME }
    public Fungus.Flowchart myFlowchart;
    public NavMeshAgent player;
    public Canvas uiSpell;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
        outline = Shader.Find("Toon/Smooth Outline");
        noLine = Shader.Find("Toon/Lit");
    }

    private void Update()
    {
        if (myFlowchart.HasExecutingBlocks())
        {
            player.enabled = false;
            uiSpell.enabled = false;
        }
        else
        {
            player.enabled = true;
            uiSpell.enabled = true;
        }

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

                case ACTIONS.DEATH:
                    {
                        myFlowchart.ExecuteBlock("Death");

                        if (myFlowchart.GetBooleanVariable("DeathRead"))
                        {
                            myFlowchart.ExecuteBlock("Death Read");
                        }

                        break; //se a acção for ESSENCIAL, adicionar a uma variável global para ser lida depois!
                    }

                case ACTIONS.MIND:
                    {
                        myFlowchart.ExecuteBlock("Mind");

                        if (myFlowchart.GetBooleanVariable("MindRead"))
                        {
                            myFlowchart.ExecuteBlock("Mind Read");
                        }

                        break; //se a acção for ESSENCIAL, adicionar a uma variável global para ser lida depois!
                    }

                case ACTIONS.MATTER:
                    {
                        myFlowchart.ExecuteBlock("Matter");

                        if (myFlowchart.GetBooleanVariable("MatterRead"))
                        {
                            myFlowchart.ExecuteBlock("Matter Read");
                        }

                        break; //se a acção for ESSENCIAL, adicionar a uma variável global para ser lida depois!
                    }

                case ACTIONS.TIME:
                    {
                        myFlowchart.ExecuteBlock("Time");

                        if (myFlowchart.GetBooleanVariable("TimeRead"))
                        {
                            myFlowchart.ExecuteBlock("Time Read");
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
        } else if (Input.GetKey(KeyCode.S))
        {
            action = ACTIONS.MATTER;
        } else if (Input.GetKey(KeyCode.D))
        {
            action = ACTIONS.DEATH;
        } else if (Input.GetKey(KeyCode.W))
        {
            action = ACTIONS.MIND;
        } else if (Input.GetKey(KeyCode.X))
        {
            action = ACTIONS.TIME;
        } else
        {
            action = ACTIONS.DEFAULT;
        }


    }

    void OnMouseOver()
    {
        myRenderer.material.shader = outline;
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        myRenderer.material.shader = noLine;
        Debug.Log("Mouse is no longer on GameObject.");
    }


}

