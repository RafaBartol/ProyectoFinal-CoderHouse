using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LogicaBuffos : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public int tipo;

    // 1 = aumento daño
    // 2 = aumento vida
    // 3 = aumento velocidad

    void Start() 
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void Efectos()
    {
        switch(tipo)
        {
            case 1:
            playerMovement.dañoPlayer += 2;
            break;

            case 2:
            playerMovement.VidaJugador += 20;
            break;

            case 3:
            playerMovement.velocidadMovimiento += 5;
            break;

            default:
            Debug.Log("No hay efecto");
            break;
        }
    }
}
