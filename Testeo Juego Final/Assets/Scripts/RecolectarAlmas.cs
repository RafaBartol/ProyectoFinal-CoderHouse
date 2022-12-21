using UnityEngine;

public class RecolectarAlmas : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Souls"))
        {
            Score.SoulsRecolected++;
            Destroy(col.transform.gameObject);
        }
    }
}
