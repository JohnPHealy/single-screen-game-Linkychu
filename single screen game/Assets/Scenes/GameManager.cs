using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 startPos;
    private int score;

    private void Start()
    {
        startPos = player.transform.position;
        score = 0;
        UpdateUI();
        GameStart();
    }

    public void RespawnPlayer ()
    {
        player.transform.position = startPos;
        score = 0;
        UpdateUI();
    }
    public void AddScore(int scoreAmt)
    {
        score += scoreAmt;
        UpdateUI();
    }

    private void UpdateUI()
    {
        addScore.Invoke(score.ToString());
    }

    public void GameStart()
    {
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void playerconfig()
    {

    }

    public void Unpause()
    {
        Time.timeScale = 1;
    }

}
