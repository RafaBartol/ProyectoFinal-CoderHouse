using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour
{
    [SerializeField] private GameObject menuMuerte;
    public Image barraDeVida;
    public float vidaMaxima = 30f;
    public float vidaActual;

    private void Start() 
    {
        vidaActual = vidaMaxima;
    }
    void Update()
    {
        RevisarVida();

        if (vidaActual <= 0)
        {
            Time.timeScale = 0f;
            menuMuerte.SetActive(true);
        }
    }

    public void RevisarVida()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
