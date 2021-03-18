using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CameraAnimator;
    public GameObject Player;
    public GameObject camera2;
    public GameObject camera1;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        CameraAnimator.SetTrigger("CameraTrigger");
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            camera2.SetActive(true);
            camera1.SetActive(false);
            Player.SetActive(false);
            StartCoroutine(finish());
        }
    }

    IEnumerator finish()
    {
        yield return new WaitForSeconds(19f);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Player.SetActive(true);
        Destroy(camera2);
        Destroy(gameObject);
        camera2.SetActive(false);
        camera1.SetActive(true);
        this.gameObject.SetActive(false);

    }
}


