using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void PlayGround()
    {
        SceneManager.LoadScene("Playground");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
