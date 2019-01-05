using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRendererOn : MonoBehaviour {

    public Renderer body;

    private void Start()
    {
        body = GetComponent<Renderer>();
    }

    public void RendererOn () {
        
        body.enabled = true;
	}

    public void RendererOff()
    {

        body.enabled = false;
    }


}
