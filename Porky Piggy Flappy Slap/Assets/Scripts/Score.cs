using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private float time;
    private float time2;
    public int score;
    public GameObject ScoreUI;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            time2 += Time.deltaTime;
            CountScore();
            DisplayScore();
        }
    }

    void CountScore()
    {
        if (time2 > 1)
        {
            score++;
            time2 = 0;
        }
    }

    void DisplayScore()
    {
        ScoreUI.GetComponent<Text>().text = ("Score: " + score);
    }
}
