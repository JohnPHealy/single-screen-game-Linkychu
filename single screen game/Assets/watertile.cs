using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watertile : MonoBehaviour
{
    public float parallaxModifier;
   

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(0, (Time.time) * parallaxModifier);

    }
}
