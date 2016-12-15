using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class EventManager : MonoBehaviour {

    public static int currentScore;

    Action<int> scoreToAdd;

    public bool canAddScore = false;

    static Text scoreText;

    //private static bool yes = true;

    void Awake()
    {
        scoreText = GetComponent<Text>();
        currentScore = 0;
        scoreText.text = "Score: " + currentScore + "/100";
        //yes = true;
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
                print("You are winner! You have 100 points!");
                break;
            default:
                break;
        }
    }
}
