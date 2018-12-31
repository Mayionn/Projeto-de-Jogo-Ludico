using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CubeObjectActions : MonoBehaviour {

    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Element()
    {
        material.color = Color.red;
    }
		
}
