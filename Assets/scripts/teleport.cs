using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public Transform teleportTarget;
    public Transform xrRig;
    
    void stratrace()
    {
        xrRig.position = teleportTarget.position;
        xrRig.rotation = teleportTarget.rotation;
    }
}
