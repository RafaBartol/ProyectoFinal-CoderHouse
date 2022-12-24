using UnityEngine;

public class LogicaBuffos : MonoBehaviour
{
    public BarraVida barraVida;
    public PlayerMovement playerMovement;

    public int tipo;

    // 1 = aumento daño
    // 2 = aumento vida

    void Start() 
    {
        barraVida = GameObject.FindGameObjectWithTag("Player").GetComponent<BarraVida>();
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void Efectos()
    {
        switch(tipo)
        {
            case 1:
            playerMovement.dañoPlayer += 0.1f;
            break;

            case 2:
            barraVida.vidaActual += 10f;
            break;
            
            default:
            Debug.Log("No hay efecto");
            break;
        }
    }
}
