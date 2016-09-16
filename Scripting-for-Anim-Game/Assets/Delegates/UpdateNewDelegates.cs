using UnityEngine;
using System.Collections;
using System;

public class UpdateNewDelegates : MonoBehaviour {

    public int health = 250;
    //Actions are a type of delegate. Delegates contain functions just as vars contain data
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndTheGame;

	// Use this for initialization
	void Start ()
    {
        //Assign function DisplayHealthHandler to the action DisplayHealth
        DisplayHealth = DisplayHealthHandler;
	}

    void EndGameHandler()
    {
        print("You is dead. Like, so dead.");
        EndTheGame = null;
    }

    void KillPlayerHandler()
    {
        health--;
        print(health);
        if (health < 0)
        {
            KillThePlayer = null;
            EndTheGame = EndGameHandler;
        }
    }

    void DisplayHealthHandler()
    {
        print("Health is good.");
        //Unassign all functions from DisplayHealth
        DisplayHealth = null;
        KillThePlayer = KillPlayerHandler;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //We check to see if any function is assigned to DisplayHealth
        //If nothing is assigned, DisplayHealth will not run
        if (DisplayHealth != null)        
            DisplayHealth();

        if (KillThePlayer != null)
            KillThePlayer();

        if (EndTheGame != null)
            EndTheGame();       
	}
}
