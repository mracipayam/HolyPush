using System;
using UnityEngine;

public class PointAreaDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out MovableItem detect)){
            detect.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
    }

    
}
