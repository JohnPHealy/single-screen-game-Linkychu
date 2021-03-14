using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{
    private GameObject[] speed;
    private PlayerMovement movescript;
    private float seconds;
    private bool obtained;
 
    void Start()
    {
        movescript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        speed = GameObject.FindGameObjectsWithTag("SpeedPowerup");
        seconds = 0;
    }

     void Update()
    {
        if (obtained == true)
        {
            seconds += 0.5f;
            dead();
        }
    }

    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (speed.Length > 0 && other.gameObject.tag == "Player")
        {

            movescript.moveSpeed += 30f;
            movescript.maxSpeed += 50f;
            obtained = true;
        }
    }

    void dead()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;

        if (seconds > 600)
        {
            obtained = false;
            movescript.moveSpeed = 5;
            movescript.maxSpeed = 10;
            Destroy(gameObject);
            seconds = 0;
        }
    }
}
