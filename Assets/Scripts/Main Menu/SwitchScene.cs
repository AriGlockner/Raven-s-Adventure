using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Start!");
    }

    public void btn_change_scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
