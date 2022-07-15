using DG.Tweening;
using UnityEngine;

public class DiamondRotateAround : MonoBehaviour
{
    

    void Update()
    {
        transform.RotateAround(transform.position,Vector3.up,20 * Time.deltaTime);
    }
}
