using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isComplete : MonoBehaviour
{
    
    public static isComplete done;
    private static bool completed;
    public bool comp;

    void Start()
    {
        completed = false;
        done = GameObject.FindWithTag("Completed").GetComponent<isComplete>();

        //DontDestroyOnLoad(done);
    }

    void Update()
    {
        if (completed != comp)
        {
            comp = completed;
        }
    }

    public static void isFinished(bool comp)
    {
        Debug.Log("Achievement Complete! 2");
        completed = comp;
        setAchiementComplete.setActive(comp);
    }
    
}
