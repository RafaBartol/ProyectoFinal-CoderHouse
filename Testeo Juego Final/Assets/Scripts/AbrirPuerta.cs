using System.Collections;
using System.Collections.Generic;
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
        if(Score.EnemiesDead == 3)
        {
            puerta1.SetActive(false);
            puerta2.SetActive(false);
        }
        else
        {
            puerta1.SetActive(true);
            puerta2.SetActive(true);
        }
    }
}
