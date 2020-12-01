using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScored : MonoBehaviour
{
    public bool isScored;

    public bool getScored()
    {
        return isScored;
    }

    void Start()
    {
        isScored = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CargoBall")
           isScored = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "CargoBall")
            isScored = false;
    }
}
