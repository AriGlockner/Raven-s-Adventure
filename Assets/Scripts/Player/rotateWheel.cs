using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWheel : MonoBehaviour
{
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = new Vector3(rotateSpeed, 0f, 0f);
        transform.Rotate(rotate * Time.deltaTime);
    }
}
