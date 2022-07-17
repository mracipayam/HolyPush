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
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.GetComponent<MeshRenderer>().enabled = false;
            GameManager.instance.inGameDiamond += 1;
            GameManager.instance.UpdateInGameDiamondDisplay();
            DOVirtual.DelayedCall(1, () => Destroy(gameObject));
        }
    }
}
