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
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    
    

    private void Start()
    {
        startPos = player.transform.position;
        GameStart();
    }

    public void RespawnPlayer ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

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
