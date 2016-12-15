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
        CheckPoints();
    }
    static void CheckPoints()
    {
        int checkInt = currentScore;
        switch (checkInt)
        {
            case (10):
                print("A drop in the bucket. You have " + currentScore + " points");
                break;
            case (50):
                print("Glass half full or half empty? You have " + currentScore + " points");
                break;
            case (100):
                print("You have 100 points! Reach the end!");
                break;
            default:
                break;
        }
    }
}
