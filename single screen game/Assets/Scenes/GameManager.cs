using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;
    

    private void Start()
    {
        startPos = player.transform.position;
        GameStart();
    }

    public void RespawnPlayer ()
    {
        player.transform.position = startPos;
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
