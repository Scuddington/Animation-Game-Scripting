using UnityEngine;
using System.Collections;
using System;

public class Teleport : MonoBehaviour {

    public Transform player;
    public GameObject ColorManager;
    public Transform PurpleTeleport;
    ColorBehaviors colorTeleport;

    void Start()
    {
        colorTeleport = ColorManager.GetComponent<ColorBehaviors>();
    }
    void OnTriggerEnter()
    {
        
        if (colorTeleport.canTeleport)
        {
            print("Teleport");
            player.position = PurpleTeleport.position;
        }

    }
}
