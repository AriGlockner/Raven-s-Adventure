using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIntake : MonoBehaviour
{
    [Header("Rotation:")]
    public float rotation;
    public float rotateSpeed;

    [Header("Min/Max rotation angles:")]
    public float minRotation;
    public float maxRotation;

    [Space(2)]
    [Header("Lift:")]
    public float liftSpeed;
    public float position;

    [Header("Min/Max Lift heights")]
    public float liftMin;
    public float liftMax;

    // Start is called before the first frame update
    void Start()
    {
        minRotation = -45f;
        maxRotation = 40f;

        liftMin = 2.5f;
        liftMax = 10.5f;

        rotateSpeed = 1f;
        liftSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Update Values
        rotation = transform.eulerAngles.x;
        if (rotation > 180f) rotation -= 360f;
        position = transform.position.y;

        //Key Input for rotation
        if (Input.GetKey(KeyCode.UpArrow) && rotation < maxRotation) rotateUp();
        if (Input.GetKey(KeyCode.DownArrow) && rotation > minRotation) rotateDown();

        //Lift
        if (Input.GetKey(KeyCode.Space) && liftMax > position) moveUp();
        if (Input.GetKey(KeyCode.LeftShift) && liftMin < position) moveDown();
    }

    //Rotate methods
    void rotateUp()
    {
        /*
        //Check out of bounds
        if (rotation > maxRotation)
        {
            transform.Rotate(maxRotation, 0f, 0f);
            return;
        }
        */
        //Rotate
        Vector3 rotate = new Vector3(maxRotation, 0f, 0f);
        transform.Rotate(rotate * Time.deltaTime * rotateSpeed);
    }

    void rotateDown()
    {
        /*
        if (rotation < minRotation)
        {
            transform.Rotate(maxRotation, 0f, 0f);
            return;
        }
        */
        Vector3 rotate = new Vector3(minRotation, 0f, 0f);
        transform.Rotate(rotate * (Time.deltaTime * rotateSpeed));
    }

    //Lift Movements
    void moveUp()
    {
        Vector3 liftAmount = new Vector3(0f, liftSpeed * liftMax, 0f);
        transform.position = transform.position + liftAmount * Time.deltaTime;
    }

    void moveDown()
    {
        Vector3 liftAmount = new Vector3(0f, liftSpeed * liftMin * 6, 0f);
        transform.position = transform.position - liftAmount * Time.deltaTime;
    }
}
