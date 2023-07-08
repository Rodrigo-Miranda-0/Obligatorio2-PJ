using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame() 
    { 
    
    }

    public void InstructionsScene()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void CreditsScene() 
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
