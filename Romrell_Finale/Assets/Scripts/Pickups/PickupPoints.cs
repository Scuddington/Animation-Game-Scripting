using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PickupPoints: MonoBehaviour
{   
    public GameObject player;
    ColorBehaviors colorPickup;
    private int numPoints = 11;

    void Start()
    {
        colorPickup = player.GetComponent<ColorBehaviors>();

        for (int i = 0; i < numPoints; i++)
        {
            print("There are " + i + " point pickups. Go get 'em.");
        }
    }

    void OnTriggerEnter()
    {
        if (colorPickup.canPickupPoints)
        {
            //Action delegate to add score from EventManager
            Action<int> value = EventManager.addScore;
            value(10);

            gameObject.SetActive(false);         
        }
    }
}
