using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{
    private GameObject[] speed;
    private PlayerMovement movescript;
    private COOLUI uiscript;
    private float seconds;
    private bool obtained;
 
    void Start()
    {
        movescript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        speed = GameObject.FindGameObjectsWithTag("SpeedPowerup");
        uiscript = GameObject.Find("COOLUI").GetComponent<COOLUI>();
        seconds = 0;
        uiscript.speed.SetActive(false);
        uiscript.none.SetActive(true);
        uiscript.jump.SetActive(false);
        uiscript.shield.SetActive(false);
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
        uiscript.speed.SetActive(true);
        uiscript.none.SetActive(false);
        uiscript.jump.SetActive(false);
        uiscript.shield.SetActive(false);

        if (seconds > 600)
        {
            obtained = false;
            movescript.moveSpeed = 5;
            movescript.maxSpeed = 10;
            Destroy(gameObject);
            seconds = 0;
            uiscript.speed.SetActive(false);
            uiscript.none.SetActive(true);
        }
    }
}
