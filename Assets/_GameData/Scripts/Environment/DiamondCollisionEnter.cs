using UnityEngine;
using DG.Tweening;

public class DiamondCollisionEnter : MonoBehaviour
{
    public Transform sparkle;

    private void Start()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out CharacterMovement detect)){
            sparkle.GetComponent<ParticleSystem>().enableEmission = true;
            transform.GetComponent<MeshRenderer>().enabled = false;
            DOVirtual.DelayedCall(1, () => Destroy(gameObject));
        }
    }
}
