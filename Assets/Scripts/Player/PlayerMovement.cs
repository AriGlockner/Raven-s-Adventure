using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Player Speed
    public float playerSpeed = 10f;

    //Rotation
    public float rotateSpeed = 180f;
    private float currentAngle;

    void Update()
    {
        //Calculates the angle in terms of pi
        currentAngle = transform.rotation.y * Mathf.PI / 180;

        //Movement Inputs
        if (Input.GetKey("left")) transform.Rotate(0f, -rotateSpeed * Time.deltaTime, 0f);
        if (Input.GetKey("right")) transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
        if (Input.GetKey("down"))
        {
            transform.Translate(Mathf.Sin(currentAngle) * Time.deltaTime * playerSpeed, 0f, Mathf.Cos(currentAngle) * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(-Mathf.Sin(currentAngle) * Time.deltaTime * playerSpeed, 0f, -Mathf.Cos(currentAngle) * Time.deltaTime * playerSpeed);
        }
    }

   

}
