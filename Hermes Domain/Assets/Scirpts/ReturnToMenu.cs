using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform exitPoint;
    public GameObject pauseMenuObj;

    public bool isInRange;


    void Update()
    {
        PauseMenu pauseScript = pauseMenuObj.GetComponent<PauseMenu>();
        if (isInRange)
        {
            PauseMenu.gameIsPaused = true;
            pauseScript.QuitToMainMenu();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        isInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }

    public void EnterMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");

    }

}