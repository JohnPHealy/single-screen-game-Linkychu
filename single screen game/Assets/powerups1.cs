using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups1 : MonoBehaviour
{
    private GameObject[] jump;
    private PlayerMovement movescript;
    private COOLUI uiscript;
    private float seconds1;
    private bool obtained1;
 
    void Start()
    {
        movescript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        jump = GameObject.FindGameObjectsWithTag("JumpPowerup");
        uiscript = GameObject.Find("COOLUI").GetComponent<COOLUI>();
        seconds1 = 0;
        uiscript.speed.SetActive(false);
        uiscript.none.SetActive(true);
        uiscript.jump.SetActive(false);
        uiscript.shield.SetActive(false);
    }

     void Update()
    {
        if (obtained1 == true)
        {
            dead1();
        }
    }

    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (jump.Length > 0 && other.gameObject.tag == "Player")
        {
            StartCoroutine(powerupend1());
            movescript.jumpForce += 10f;
            obtained1 = true;
            
        }
    }

    void dead1()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        uiscript.speed.SetActive(false);
        uiscript.none.SetActive(false);
        uiscript.jump.SetActive(true);
        uiscript.shield.SetActive(false);
    }

    IEnumerator powerupend1()
        {
        yield return new WaitForSeconds(7f);
        obtained1 = false;
            movescript.jumpForce = 5f;
            Destroy(gameObject);
            uiscript.jump.SetActive(false);
            uiscript.none.SetActive(true);

        }
    }
