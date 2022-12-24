using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEsqueleto : MonoBehaviour
{
    public BarraVida barraDeVida;
    public int dañoEsqueleto;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            barraDeVida.vidaActual -= dañoEsqueleto;
        }  
    }
}
