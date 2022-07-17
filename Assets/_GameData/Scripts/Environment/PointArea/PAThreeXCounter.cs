using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAThreeXCounter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MovableItem detect))
        {
            GameManager.instance.PointAreaThreeX++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MovableItem detect))
        {
            GameManager.instance.PointAreaThreeX--;
        }
    }
}
