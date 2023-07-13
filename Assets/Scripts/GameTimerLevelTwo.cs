using System.Colusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimerLevelTwo : MonoBehaviour
{
    public float timeRemaining = 120;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    // Update is called once per frame
    private IEnumerator TimerCoroutine()
    {
        yield return new WaitForSeconds(timeRemaining);
        SceneManager.LoadSceneAsync("LevelUpTwoScene");
    }
}
