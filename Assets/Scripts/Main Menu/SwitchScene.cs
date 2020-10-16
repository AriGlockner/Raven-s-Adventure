using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public int goToScene;

    void Start()
    {
        Debug.Log("Start!");
    }

    void TaskOnClick()
    {
        Debug.Log("Load Scene: " + goToScene);
        SceneManager.LoadScene(sceneBuildIndex:goToScene);
    }
}
