using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarArma : MonoBehaviour
{
    public GameObject[] armas;
    public BoxCollider[] espadaBoxCol;
    public PlayerMovement playerMovement;

    void Start()
    {
        DesactivarCollidersArmas();
    }

    public void ActivarArma(int numero)
    {
        for(int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        armas[numero].SetActive(true);

        playerMovement.conArma = true;
    }

    public void ActivarColliderEspada()
    {
        for (int i = 0; i < espadaBoxCol.Length; i++)
        {
            if(espadaBoxCol[i] != null)
            {
                espadaBoxCol[i].enabled = true;
            }
        }
    }

    public void DesactivarCollidersArmas()
    {
        for (int i = 0; i < espadaBoxCol.Length; i++)
        {
            if(espadaBoxCol[i] != null)
            {
                espadaBoxCol[i].enabled = false;
            }
        }
    }
}
