using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}

