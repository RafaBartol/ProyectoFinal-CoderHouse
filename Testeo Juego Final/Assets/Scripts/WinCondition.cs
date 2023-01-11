using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
<<<<<<< Updated upstream
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
=======
    [SerializeField] private GameObject MenuWin;

    private void Update() 
    {
        if (Score.Orbs == 9 && Score.SoulsRecolected == 13)
        {
            Time.timeScale = 0f;
            MenuWin.SetActive(true);
        }   
>>>>>>> Stashed changes
    }
}
