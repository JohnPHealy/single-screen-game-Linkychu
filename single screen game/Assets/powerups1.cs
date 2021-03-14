using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups1 : MonoBehaviour
{
    private GameObject[] jump;
    private PlayerMovement movescript;
    private float seconds1;
    private bool obtained1;
 
    void Start()
    {
        movescript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        jump = GameObject.FindGameObjectsWithTag("JumpPowerup");
        seconds1 = 0;
    }

     void Update()
    {
        if (obtained1 == true)
        {
            seconds1 += 0.5f;
            dead1();
        }
    }

    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (jump.Length > 0 && other.gameObject.tag == "Player")
        {

            movescript.jumpForce += 10f;
            obtained1 = true;
        }
    }

    void dead1()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;

        if (seconds1 > 1500)
        {
            obtained1 = false;
            movescript.jumpForce = 5f;
            Destroy(gameObject);
        }
    }
}
