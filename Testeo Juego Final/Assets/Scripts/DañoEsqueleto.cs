using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEsqueleto : MonoBehaviour
{
    public int dañoEsqueleto = 3;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            other.transform.gameObject.GetComponent<PlayerMovement>().VidaJugador -= dañoEsqueleto;
        }  
    }
}
