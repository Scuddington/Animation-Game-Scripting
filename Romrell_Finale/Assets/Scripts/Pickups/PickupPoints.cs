using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupPoints: MonoBehaviour
{

    public GameObject player;
    public GameObject ColorManager;
    ColorBehaviors colorPickup;
    private int score = 0;

    void Start()
    {
        colorPickup = ColorManager.GetComponent<ColorBehaviors>();
        print(score);
    }

    void OnTriggerEnter()
    {
        if (colorPickup.canPickupPoints)
        {
            print("Ten points to Gryffindor");

            score += 1;
            print(score);
            //GetComponent<Collider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            //gameObject.SetActive(false);
        }
        if (score > 2)
        {
            print("Winner winner");
        }
    }
}
