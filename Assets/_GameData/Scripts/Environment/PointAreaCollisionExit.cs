using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAreaCollisionExit : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.TryGetComponent(out MovableItem detect)){
            detect.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
