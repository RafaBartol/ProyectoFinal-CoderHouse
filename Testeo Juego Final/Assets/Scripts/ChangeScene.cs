using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public int numberScene;
    public GameObject optionsBackground;
    public GameObject extrasBackground;
    public Image extra1Locked;//bloqueado
    public Sprite extra1;
    private bool ExtraLike;

    private void Start()
    {
        ExtraLike = PlayerPrefs.GetInt("extralike") == 1;
    }

    private void Update()
    {
        if(ExtraLike == true)//extralike es el trofeo
        {
            extra1Locked.sprite = extra1;
        }
    }



    public void changeScene()
    {
      SceneManager.LoadScene(1);
    }

   
   public void Options()
    {
      optionsBackground.SetActive(true);
    }

     public void extras()
    {
      extrasBackground.SetActive(true);
    }

    public void Return()
    {
      optionsBackground.SetActive(false);
      extrasBackground.SetActive(false);
    }



public void Exit()
{
    Application.Quit();
    Debug.Log("Aplicacion Cerrada");
}

}
