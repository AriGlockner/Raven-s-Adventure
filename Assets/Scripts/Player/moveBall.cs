using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    [Header("Speed at which ball goes in/out:")]
    public float speed;
    public float outputSpeed;

    [Header("Ball location:")]
    public bool insideIntake;

    void Start()
    {
        insideIntake = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            insideIntake = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            insideIntake = false;
            other.attachedRigidbody.AddForce(transform.forward * -outputSpeed);
        }

        else if (insideIntake && other.attachedRigidbody)
        {
            Vector3 force = transform.position - other.transform.position;
            other.attachedRigidbody.AddForce(force * speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && other.attachedRigidbody)
        {
            insideIntake = true;
            Vector3 force = transform.position - other.transform.position;
            other.attachedRigidbody.AddForce(force * speed);
        }
    }
}
