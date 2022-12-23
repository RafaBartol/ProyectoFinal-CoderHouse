using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool menuOn;
    

    // Update is called once per frame
    void Update()
    {

     if(Input.GetKeyDown(KeyCode.Escape))
    {
        menuOn = !menuOn;
    }

    if(menuOn == true)
    {
    pauseMenu.SetActive(true);  
    Time.timeScale = 0;  
    }
    else
    {
      menuDisabled();
    }

    }

public void Continue()
{
     menuDisabled();
   menuOn = false; 
}

public void backToTop()
{
  SceneManager.LoadScene(0);
}

public void menuDisabled()
{
       pauseMenu.SetActive(false);  
        Time.timeScale = 1; 
}


}
