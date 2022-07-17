using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAFiveXCounter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MovableItem detect))
        {
            GameManager.instance.PointAreaFiveX++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MovableItem detect))
        {
            GameManager.instance.PointAreaFiveX--;
        }
    }
}
