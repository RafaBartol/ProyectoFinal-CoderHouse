using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        CondicionVictoria();
    }

    void CondicionVictoria()
    {
        if (Score.Orbs == 1)
        {
            Debug.Log("Has ganado");
        }
    }
}
