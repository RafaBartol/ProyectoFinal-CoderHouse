using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogroLike : MonoBehaviour
{
    public GameObject logroConseguido;
    private bool ExtraLike = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           
            logroConseguido.SetActive(true);
            ExtraLike = true;
            PlayerPrefs.SetInt("extralike", ExtraLike ? 1 : 0);
            Destroy(gameObject);
             Debug.Log("Player");  
        }
    }
}
