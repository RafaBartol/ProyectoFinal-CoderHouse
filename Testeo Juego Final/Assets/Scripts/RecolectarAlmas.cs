using UnityEngine;

public class RecolectarAlmas : MonoBehaviour
{
    private void Start() 
    {
        Score.SoulsRecolected = 0;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Souls"))
        {
            Score.SoulsRecolected++;
            Destroy(col.transform.gameObject);
        }
    }
}
