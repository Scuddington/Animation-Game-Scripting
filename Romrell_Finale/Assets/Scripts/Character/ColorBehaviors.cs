using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ColorBehaviors : MonoBehaviour {

    // public List<Material> ColorBlocks;
    public GameObject player;
    public GameObject Green;
    public GameObject Red;
    public GameObject Purple;
    public int ColorBlocks;
    //public Transform PurpleTeleport;
    public bool canTeleport;
    public bool canPickupPoints;

    //public static Action<Transform> SendPlayer;
    // Use this for initialization
    //void Start () {
    //    if (SendPlayer != null)
    //    {
    //        SendPlayer(transform);
    //    }
    //}
         


    // Update is called once per frame
    void OnTriggerStay()
    {

        StartCoroutine(CaseChange());
        switch (ColorBlocks)
        {
            case 3:
                if (player.GetComponent<Renderer>().material.color == Green.GetComponent<Renderer>().material.color)
                {
                    print("You are Green");
                    Physics.IgnoreLayerCollision(8, 13, true);
                    StartCoroutine(TurnLayerBackOn());
                }
                //else if (gameObject.GetComponent<Renderer>().material.color != gameObject.GetComponent<Renderer>().material.color)
                //{
                //    Physics.IgnoreLayerCollision(8, 13, false);
                //}

                break;

            case 2:
                if (player.GetComponent<Renderer>().material.color == Red.GetComponent<Renderer>().material.color)
                {
                    print("You are red, and can now pick up red spheres for points");
                    canPickupPoints = true;
                }
                break;

            case 1:
                if (player.GetComponent<Renderer>().material.color == Purple.GetComponent<Renderer>().material.color)
                {
                    print("You are purple, and can now teleport from one purple wall to another");
                    canTeleport = true;
                }
                break;

            default:
                print("No colors");
                break;

        }
	
	}

    public IEnumerator TurnLayerBackOn()
    {
        yield return new WaitForSeconds(1.5f);
        print("Uhhhh");
        Physics.IgnoreLayerCollision(8, 13, false);
    }

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
        if (player.GetComponent<Renderer>().material.color == Green.GetComponent<Renderer>().material.color)
        {
            ColorBlocks = 3;
        }
        yield return null;
    }
}
