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

    //public static Action<Transform> SendPlayer;
    // Use this for initialization
    //void Start () {
    //    if (SendPlayer != null)
    //    {
    //        SendPlayer(transform);
    //    }
    //}

    


    // Update is called once per frame
    void OnTriggerEnter () {

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
                else if (gameObject.GetComponent<Renderer>().material.color != gameObject.GetComponent<Renderer>().material.color)
                {
                    Physics.IgnoreLayerCollision(8, 13, false);
                }

                break;

            case 2:
                if (player.GetComponent<Renderer>().material.color == Red.GetComponent<Renderer>().material.color)
                {
                    print("You are Red");
                }
                break;

            case 1:
                if (player.GetComponent<Renderer>().material.color == Purple.GetComponent<Renderer>().material.color)
                    print("You are Purple");
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
        ColorBlocks = 1;
        yield return null;
    }
}
