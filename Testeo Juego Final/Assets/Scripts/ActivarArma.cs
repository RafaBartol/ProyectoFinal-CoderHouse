using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarArma : MonoBehaviour
{
    public AgarrarArma agarrarArma;
    public int numeroArma;

    void Start()
    {
        agarrarArma = GameObject.FindGameObjectWithTag("Player").GetComponent<AgarrarArma>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            agarrarArma.ActivarArma(numeroArma);
            Destroy(gameObject);
        }
    }
}
