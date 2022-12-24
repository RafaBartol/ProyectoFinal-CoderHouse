using UnityEngine;

public class RecolectarOrbes : MonoBehaviour
{
    private void Start() 
    {
        Score.Orbs = 0; 
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Orbs"))
        {
            Score.Orbs++;
            Destroy(col.transform.gameObject);
        }
    }
}
