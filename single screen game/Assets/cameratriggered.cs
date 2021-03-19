using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratriggered : MonoBehaviour
 
{
    public GameObject camera1;
    public GameObject camera2;


    void Start()
    {
        camera1.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera2.SetActive(false);
            camera1.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
}
