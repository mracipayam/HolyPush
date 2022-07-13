using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAreaDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out MovableItem detect)){
            detect.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
    }
}
