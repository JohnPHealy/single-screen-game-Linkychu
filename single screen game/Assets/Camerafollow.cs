using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform Target;

    public float speed = 10f;
    public Vector3 Offset;
    private void FixedUpdate()
    {
        Vector3 desPos = Target.position + Offset;
        Vector3 smoPos = Vector3.Lerp(transform.position, desPos, speed * Time.deltaTime);
        transform.position = desPos;

        transform.LookAt(Target);
    }
}
