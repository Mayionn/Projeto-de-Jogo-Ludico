using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Fungus;

public class NavMeshOnOff : MonoBehaviour {

    public NavMeshAgent player;
    public Fungus.Flowchart myFlowchart;

    void EnableNavMesh () {
        if (myFlowchart.HasExecutingBlocks())
        {
            player.enabled = false;
 
        }
        else
        {
            player.enabled = true;

        }
    }
	

	void DisableNavMesh () {
        if (myFlowchart.HasExecutingBlocks())
        {
            player.enabled = false;

        }
        else
        {
            player.enabled = true;

        }
    }
}
