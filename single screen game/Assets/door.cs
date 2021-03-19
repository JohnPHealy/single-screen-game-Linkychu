using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door : MonoBehaviour
{
    public COOLUI coolui;
    void Start()
    {
        coolui = GameObject.Find("COOLUI").GetComponent<COOLUI>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && coolui.score >=280)
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }
}

