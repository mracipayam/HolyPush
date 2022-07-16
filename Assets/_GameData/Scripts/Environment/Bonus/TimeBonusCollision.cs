using DG.Tweening;
using UnityEngine;

public class TimeBonusCollision : MonoBehaviour
{
    public Transform sparkle;

    private void Start()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out CharacterMovement detect))
        {
            sparkle.GetComponent<ParticleSystem>().enableEmission = true;
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.GetComponent<MeshRenderer>().enabled = false;
            DOVirtual.DelayedCall(1, () => Destroy(gameObject));
        }
    }
}
