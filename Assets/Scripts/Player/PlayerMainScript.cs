using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMainScript : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P)) pauseGame();
    }

    void pauseGame()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Pause Screen");
    }
    
}
