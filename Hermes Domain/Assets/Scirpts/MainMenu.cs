using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EnterGame()
    {
        SceneManager.LoadScene("Tutorial");
        PauseMenu.gameIsPaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("The Game Has Quit");
        Application.Quit();
    }

    public void EnterPracticeArena()
    {
        SceneManager.LoadScene("Practice Arena");
        PauseMenu.gameIsPaused = false;
    }
}
