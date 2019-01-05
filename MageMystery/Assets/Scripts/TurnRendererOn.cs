using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRendererOn : MonoBehaviour {

    public Renderer thing;

    private void Start()
    {
        thing = GetComponent<Renderer>();
    }

    public void RendererOn () {
        
        thing.enabled = true;
	}

    public void RendererOff()
    {

        thing.enabled = false;
    }


}
