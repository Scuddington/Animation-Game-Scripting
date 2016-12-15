using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class EventManager : MonoBehaviour {

    public static int currentScore;

    Action<int> scoreToAdd;

    public bool canAddScore = false;

    static Text scoreText;

    void Awake()
    {
        scoreText = GetComponent<Text>();
        currentScore = 0;
        scoreText.text = "Score: " + currentScore + "/100";
    }

    public static void addScore(int score)
    {
        currentScore += score;
        scoreText.text = "Score: " + currentScore + "/100";
        if (currentScore >= 100)
            print ("You win!");
    }
}
