using UnityEngine;

public class Granada : MonoBehaviour
{
    public GameObject efectoExplosion; //boom
    public float delay = 3f;

    public float radius  =20f;
    public float explosionForce = 10f;

    void Start()
    {
        Invoke("ExplotarGranada",delay);
    }

    void ExplotarGranada()
    {
        //chequear colliders cercanos
        Collider[] cols = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider near in cols)
        {
            Rigidbody rb = near.GetComponent<Rigidbody>();

            if(rb != null)
            {
               rb.AddExplosionForce(explosionForce,transform.position,radius,1f,ForceMode.Impulse);
            }

        }

        Instantiate(efectoExplosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }

}
