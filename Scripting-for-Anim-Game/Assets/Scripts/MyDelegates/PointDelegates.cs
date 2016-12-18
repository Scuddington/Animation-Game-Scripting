using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PointDelegates : MonoBehaviour {

    Action<int> ScoreAdd;
    Action<int> ScoreTake;
    public static int currentScore;
    static Text scoreText;


    // Use this for initialization
    void Start () {
        scoreText = GetComponent<Text>();
        currentScore = 0;
        scoreText.text = "The score is " + currentScore + "/5";
	}
	
    public static void scoreAdd(int score)
    {
        currentScore += score;
        scoreText.text = "The score is " + currentScore + "/5";
    }

    public static void scoreTake(int scoreOff)
    {
        currentScore -= scoreOff;
        scoreText.text = "The score is " + currentScore + "/5";
    }

}
