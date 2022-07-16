using UnityEngine;
using DG.Tweening;

public class DiamondRotateAround : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(transform.position,Vector3.up,30 * Time.deltaTime);
        //transform.DOMoveY(3f, 1f).OnComplete(() => transform.DOMoveY(0.83f, 1f));
    }
}
