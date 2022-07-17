
using UnityEngine;
using DG.Tweening;

public class Bomb : MonoBehaviour
{
    public float radius;
    public float explotionForce;
    public GameObject explotionFX;
    public GameObject body;

    private void Start()
    {
        DOVirtual.DelayedCall(5, () => knockBack());
    }

    public void knockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        explotionFX.SetActive(true);
        body.transform.GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Collider>().enabled = false;
        //GetComponent<Rigidbody>().isKinematic = true;


        foreach (Collider nearby in colliders)
        {
            Rigidbody rigidbody = nearby.GetComponent<Rigidbody>();

            if(rigidbody != null)
            {
                rigidbody.AddExplosionForce(explotionForce, transform.position, radius);
            }
        }
        DOVirtual.DelayedCall(1, () => Destroy(gameObject));
    }
}
