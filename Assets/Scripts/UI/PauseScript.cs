using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (gameIsPaused) 
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Resume() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ContinueGameScene()
    {
        
    }

    public void MainScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
