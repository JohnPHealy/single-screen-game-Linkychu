using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;


public class Slider : MonoBehaviour
{
    public Color colour;
    public GameObject PlayerImage;
    public GameObject PlayerSkin;


    float red;
    float blue;
    float green;

     void Start()
    {
        red = 255f;
        blue = 255f;
        green = 255f;
    }

    public void RED(float newRed)
    {
        red = newRed;
    }

    public void BLUE(float newBlue)
    {
        blue = newBlue;
    }


    public void GREEN(float newGreen)
    {
        green = newGreen;
    }

    void Update()
    {
        PlayerImage.GetComponent<Image>().color = new Color(red, blue, green);
        PlayerSkin.GetComponent<SpriteRenderer>().color = new Color(red, blue, green);
    }
}
