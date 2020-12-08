using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScored : MonoBehaviour
{
    [Header("Balls:")]
    private ballScored ball;
    public isComplete comp;
    public int score;
    public int numToScore;

    public void setScore(bool positive)
    {
        if (positive)
            score++;
        else
            score--;

        if (score == numToScore)
            achievementComplete();
        else if (score < 0)
            throw new System.Exception("The score cannot be less than 0.");
    }

    void Start()
    {
        ball = GameObject.FindWithTag("Canvas").GetComponent<ballScored>();
        comp = isComplete.done;

        DontDestroyOnLoad(ball);
        //DontDestroyOnLoad(comp);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            setScore(true);
            /*
            score++;
            if (score == numToScore)
                achievementComplete();
            */
        }            
    }
    

    public static void achievementComplete()
    {
        isComplete.isFinished(true);
    }
}
