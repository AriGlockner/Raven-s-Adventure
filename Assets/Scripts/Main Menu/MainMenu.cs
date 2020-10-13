using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isConrol;
    public bool isQuit;

    void OnMouseUp()
    {
        if (isStart)
        {
            Application.LoadLevel(2);
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (isQuit) Application.Quit();
        if (isConrol)
        {
            Application.LoadLevel(1);
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}