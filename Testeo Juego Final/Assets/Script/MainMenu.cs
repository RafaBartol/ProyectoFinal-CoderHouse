using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     void Start()
 {
   Time.timeScale = 1;//  cuando vuelvo al menú quiero que tenga la escala original

     }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
public void Exit()
{
    Application.Quit();

}
}
