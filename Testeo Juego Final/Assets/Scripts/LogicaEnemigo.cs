using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public float vidaEnemigo = 50f;

    void Update() 
    {
        if(vidaEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Le has dado a un enemigo");
        }  
    }
}
