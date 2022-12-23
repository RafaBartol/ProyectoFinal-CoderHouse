using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudGame : MonoBehaviour
{
     
     public Text scoreText;// texto que hace ref al TEXTO PUNTAJE
     //public static int enemixLife = 0;// cada vez que mate a enemy aumentara el valor en 1
    public static int dead_Chackra = 0;


     [Header ("LifeOfBar")]//VIDA DE BARRA
     public Image barLife;//IMAGEN BARRA
     public float actualLife;// VIDA ACTUAL
     public float maxLife = 100;// MAX VIDA
     
      [Header ("ImageOfBar")] // IMAGEN DE LA BARRA
     public Image imageLife;
     public float imageActualLife ; // puede ser que ambas variables haya que cambiarlas
     public float imageMaxLife = 600f;//

       [Header ("PAUSE")]
     private bool pauseActive;
     public GameObject menuPause;
     public GameObject hud;


       void Update()
    // HAY ALGO EN ACTUAL LIFE QUE NO SE ACTUALIZA EN - imageActualLife
    {
      //scoreText.text = "Hello";//ingreso al componente texto y dentro de el modifico el text
       // se ve reflejado en el cambio de la variable de puntaje de la UI
    
      //scoreText.text = "x :" + enemixLife.ToString();//me convierte de un entero a un string
       
        scoreText.text = "x :" + dead_Chackra.ToString();//me convierte de un entero a un string
               
               imageLife.color = new Color ( 255,255,255, -imageActualLife / imageMaxLife);
 
        
          imageLife.fillAmount = - imageActualLife / imageMaxLife;//para escalar el valor de imageLife

              actualLife = GunPlayer.playerLife;// a que es igual la vida actual

       imageActualLife = GunPlayer.playerLife;// a que es igual la vida actual
        

        barLife.fillAmount = actualLife / maxLife; // Escala el valor de 0 a 1 para vincularlo a barLife   
        
      
   

        TogglePause();// metodo que va a desact la pausa si esta activa o no
    }


    public void TogglePause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseActive)
            ResumeGame();
            else
            PauseGame();
        }
    }
    void  PauseGame()
    {
        menuPause.SetActive(true);
        pauseActive = true;
        hud.SetActive(false);
        Time.timeScale = 0.01f;// si es 0 es pausa

    }
    void  ResumeGame()
    {
        menuPause.SetActive(false);
        pauseActive = false;
        hud.SetActive(true);
        Time.timeScale = 1;// si es 0 es pausa

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
