using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public int hp;
    public int damageEspada;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Espada")
        {
            hp -= damageEspada;
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
