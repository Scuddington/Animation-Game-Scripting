using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Teleport : MonoBehaviour {

    public Transform player;
    public Transform PurpleTeleport;
    public GameObject ColorManager;
    public List<Transform> players;

    ColorBehaviors colorTeleport;

    private int playerNum;

    void Start()
    {
        colorTeleport = ColorManager.GetComponent<ColorBehaviors>();
        colorTeleport.canTeleport = false;
        //accessing the SendPlayer Action
        SendPlayer.SendPlayerTo += PlayerHandler;
    }

    //Add player to Transform list
    void PlayerHandler (Transform _p)
    {
        players.Add(_p);
    }

    //Teleport player to transform position using Actions
    void OnTriggerEnter()
    {        
        if (colorTeleport.canTeleport)
        {
            players[playerNum].position = PurpleTeleport.position;
        }
    }
}
