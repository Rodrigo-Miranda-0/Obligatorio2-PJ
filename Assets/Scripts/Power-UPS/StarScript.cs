using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    [SerializeField] private int pointAmmount = 500;
    [SerializeField] ScoreHandler scoreHandler;

    void Start()
    {
        scoreHandler = GameObject.FindWithTag("Canvas").GetComponentInChildren<ScoreHandler>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (scoreHandler != null)
        {
            scoreHandler.UpdateScore(pointAmmount);
        }
        Destroy(gameObject);
    }
}
