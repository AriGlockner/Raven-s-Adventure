using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [Header("Player Movement")]
    public float playerAcceleration;
    private Rigidbody rb;
    public float mass;
    public float maxSpeed;

    [Header("Player Rotation")]
    public float rotateSpeed = 180f;
    public float currentAngle;

    [Header("Forces stuff")]
    public Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }

    void Update()
    {
        //Calculates the angle in terms of pi
        //currentAngle = transform.rotation.y * Mathf.PI / 180;
        currentAngle = transform.rotation.y * 180;

        movement = new Vector3(0f, 0f, 0f);

        //Rotate Player
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0f, -rotateSpeed * Time.deltaTime, 0f);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);

        //Player Movements
        if (Input.GetKey(KeyCode.W))
            moveForward();

        else if (Input.GetKey(KeyCode.S))
            moveBackwards();

        applyForces();
    }

    void moveForward()
    {
        movement = -transform.forward.normalized;
    }

    void moveBackwards()
    {
        movement = transform.forward.normalized;
    }

    void applyForces()
    {
        float speed = rb.velocity.magnitude;
        speed *= speed;

        rb.AddForce(movement * (playerAcceleration - speed) * Time.deltaTime * mass, ForceMode.Impulse);
    }

}
