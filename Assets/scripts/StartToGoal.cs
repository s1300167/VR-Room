using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartToGoal : MonoBehaviour
{

    public Transform teleportTarget;
    public Transform xrRig;
    
    void stratrace(Collider other)
    {
        if (other.CompareTag("MeinCamera"))
        {
            xrRig.position = teleportTarget.position;
            xrRig.rotation = teleportTarget.rotation;

            Debug.Log("Bug");
        }
    }
}
