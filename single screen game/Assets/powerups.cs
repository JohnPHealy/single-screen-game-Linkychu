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

    void reappear()
    {
        seconds = 0;
        gameObject.SetActive(true);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }
    void Update()
    {
        if (obtained == true)
        {
            seconds++;
            dead();
        }
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (speed.Length > 0 && other.gameObject.tag == "Player")
        {
            StartCoroutine(powerupend());
            movescript.moveSpeed += 30f;
            movescript.maxSpeed += 50f;
            obtained = true;

        }
    }

    void dead()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        uiscript.speed.SetActive(true);
        uiscript.none.SetActive(false);
        uiscript.jump.SetActive(false);
        uiscript.shield.SetActive(false);
    }

    IEnumerator powerupend()
    {
        yield return new WaitForSeconds(1.5f);
        obtained = false;
        movescript.moveSpeed = 5;
        movescript.maxSpeed = 10;
        uiscript.speed.SetActive(false);
        uiscript.none.SetActive(true);
        gameObject.SetActive(false);
        
        if (seconds > 200)
        {
            reappear();
        }
    }
} 


   

