using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PickupPoints: MonoBehaviour
{   
    public GameObject player;
    ColorBehaviors colorPickup;

    void Start()
    {
        colorPickup = player.GetComponent<ColorBehaviors>();
    }

    void OnTriggerEnter()
    {
        if (colorPickup.canPickupPoints)
        {
            //delegate to add score from EventManager
            Action<int> value = EventManager.addScore;
            value(50);

            gameObject.SetActive(false);         
        }
    }
}
