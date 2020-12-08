using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScoredAtLocation : MonoBehaviour
{
    public ballScored ball;
    public bool isScored;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Canvas").GetComponent<ballScored>();

        DontDestroyOnLoad(ball);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("CargoBall"))
        {
            isScored = true;
            ball.setScore(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("CargoBall"))
        {
            isScored = false;
            ball.setScore(false);
        }
    }
}
