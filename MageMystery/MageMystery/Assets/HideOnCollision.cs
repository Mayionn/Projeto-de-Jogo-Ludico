using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnCollision : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            other.gameObject.GetComponent<Renderer>().enabled = false;
            Debug.Log("hit" + other);
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            other.gameObject.GetComponent<Renderer>().enabled = true;
            Debug.Log("Leave");
        }
    }
}
