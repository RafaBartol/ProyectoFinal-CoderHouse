using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;
    public GameObject puerta5;
    public GameObject puerta6;

    void Update()
    {
        abrirPuerta();
    }

    void abrirPuerta()
    {
        if (Score.EnemiesDead == 1 && Score.SoulsRecolected == 1 && Score.Orbs == 1)
        {
            puerta1.SetActive(false);
        }
    }
}
