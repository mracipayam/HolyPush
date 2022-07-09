using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionDetection : MonoBehaviour
{
    public Animator animator;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.TryGetComponent(out MovableItem detect)){
            animator.SetBool("isPushing",true);
        }
    }
    private void OnCollisionExit(Collision other) {
         if(other.gameObject.TryGetComponent(out MovableItem detect)){
            animator.SetBool("isPushing",false);
        }
    }
}
