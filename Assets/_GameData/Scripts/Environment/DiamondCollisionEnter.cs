using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollisionEnter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out CharacterMovement detect)){
            
        }
    }
}
