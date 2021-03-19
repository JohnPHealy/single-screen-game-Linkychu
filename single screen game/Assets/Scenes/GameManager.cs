using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;
    int failed;
    public Slider slider;
    public GameObject menu;
    public GameObject menu2;
    public GameObject menu3;
    public COOLUI coolui;

    
    

    private void Start()
    {

        startPos = player.transform.position;
        GameStart();
    }

    public void Restart ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);

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

    public void RespawnPlayer()
    {
        player.transform.position = new Vector3 (-3.9000001f, -3.63000011f, 1f);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
