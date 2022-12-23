using UnityEngine;

public class Lanzador : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject granade_prefab;

    public float range = 10f;
    
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Throw();
        }
    }

    void Throw()
    {
        GameObject go = Instantiate(granade_prefab, spawnPoint.position, spawnPoint.rotation);
        go.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
    }
}
