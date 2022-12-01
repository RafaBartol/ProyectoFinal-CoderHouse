using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarBuffos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Buffo"))
        {
            other.GetComponent<LogicaBuffos>().Efectos();
            Destroy(other.gameObject);
        }    
    }
}
