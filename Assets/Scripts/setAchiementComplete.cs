using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setAchiementComplete : MonoBehaviour
{
    private static bool isActive = false;
    public bool achievmentCompleted;
    public Image fillARocket;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //DontDestroyOnLoad(fillARocket);

        fillARocket = GameObject.FindWithTag("Completed").GetComponent<Image>();
        fillARocket.enabled = false;
    }

    void Update()
    {
        fillARocket.enabled = isActive;

        achievmentCompleted = isActive;
    }

    public static void setActive(bool active)
    {
        isActive = active;
    }
}
