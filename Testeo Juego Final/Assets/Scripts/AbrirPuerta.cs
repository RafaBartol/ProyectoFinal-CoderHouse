using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public GameObject puerta1;  
    public GameObject puerta2;  
    
    void Update()
    {
        abrirPuerta();
    }

    void abrirPuerta()
    {
        if (Score.Orbs == 1)
        {
            puerta1.SetActive(false);
            puerta2.SetActive(false);
        }
    }
}
