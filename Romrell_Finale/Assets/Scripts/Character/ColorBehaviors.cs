using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ColorBehaviors : MonoBehaviour {

    public GameObject player;
    public GameObject Green;
    public GameObject Red;
    public GameObject Purple;

    private static int ColorBlocks;

    public bool canTeleport;
    public bool canPickupPoints;

    public string color;

    void OnTriggerEnter()
    {
        //every time a trigger is...triggered, the coroutine starts to check which case it should be using
        StartCoroutine(CaseChange());
        switch (ColorBlocks)
        {
            case 3:
                //If player is green, player can pass through green walls
                if (player.GetComponent<Renderer>().material.color == Green.GetComponent<Renderer>().material.color)
                {
                    print("You are green, and can pass through green walls");
                    //turns off layer collision between Player and ThroughWalls layers
                    Physics.IgnoreLayerCollision(8, 13, true);
                    StartCoroutine(TurnLayerBackOn());
                }
                break;

            case 2:
                //if player is Red, player can pick up red points
                if (player.GetComponent<Renderer>().material.color == Red.GetComponent<Renderer>().material.color)
                {
                    print("You are red, and can now pick up red spheres for points");
                    canPickupPoints = true;
                    StartCoroutine(PickupPointsOff());
                }
                break;

            case 1:
                //if player is Purple, can teleport through purple walls
                if (player.GetComponent<Renderer>().material.color == Purple.GetComponent<Renderer>().material.color)
                { 
                    canTeleport = true;
                    print("You are purple, and can now teleport from one purple wall to another");
                    StartCoroutine(TeleportOff());
                }
                break;

            default:
                break;
        }	
	}

    //Coroutines
    //waits and then turns the layer collision back on
    public IEnumerator TurnLayerBackOn()
    {
        yield return new WaitForSeconds(1.5f);
        Physics.IgnoreLayerCollision(8, 13, false);
    }

    //turns off the ability to teleport
    IEnumerator TeleportOff()
    {
        yield return new WaitForSeconds(1f);
        canTeleport = false;
        print("no teleport");
    }

    //points become unable to be picked up
    IEnumerator PickupPointsOff()
    {
        yield return new WaitForSeconds(0.001f);
        canPickupPoints = false;
    }

    //Enumerator to change the case 
    public IEnumerator CaseChange()
    {
        if (player.GetComponent<Renderer>().material.color == Purple.GetComponent<Renderer>().material.color)
        {
            ColorBlocks = 1;
        }
        if (player.GetComponent<Renderer>().material.color == Red.GetComponent<Renderer>().material.color)
        {
            ColorBlocks = 2;
        }
        else if (player.GetComponent<Renderer>().material.color == Green.GetComponent<Renderer>().material.color)
        {
            ColorBlocks = 3;
        }

        yield return null;
    }
}
