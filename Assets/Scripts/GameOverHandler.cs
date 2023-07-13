using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public void GameOver()
    {
        StartCoroutine(LoadGameOverCoroutine());
    }
    private IEnumerator LoadGameOverCoroutine()
    {
        Debug.Log("Loading Game Over Scene");
        yield return new WaitForSeconds(3);
        Debug.Log(" Game Over Scene");
        SceneManager.LoadSceneAsync("LoseScene");
    }
}
