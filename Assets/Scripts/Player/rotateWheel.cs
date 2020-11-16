using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWheel : MonoBehaviour
{
    public float rotateSpeed;
    public int direction;

    void Update()
    {
        //Sets direction to rotate
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            direction = 1;
        else if (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
            direction = -1;
        else
            direction = 0;

        //Rotates
        Vector3 rotate = new Vector3(rotateSpeed, 0f, 0f);
        transform.Rotate(direction * rotate * Time.deltaTime);
    }
}
