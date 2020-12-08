using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAchiementComplete : MonoBehaviour
{
    private static bool isActive = false;
    public bool achievmentCompleted;

    void Start()
    {
        this.gameObject.SetActive(false);
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        this.gameObject.SetActive(isActive);
        achievmentCompleted = isActive;
    }

    public static void setActive(bool active)
    {
        if (isActive != active)
        {
            isActive = active;
            //thisObject.SetActive(isActive);
        }
    }

    /*
    public static setAchiementComplete()
    {
        thisObject = new setAchiementComplete();
    }
    

    void Start()
    {
        this.gameObject.SetActive(false);
        thisObject = this.gameObject;
        DontDestroyOnLoad(thisObject);
    }

    public static void setActive(bool active)
    {
        thisObject.SetActive(active);
    }
    */
}
