using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupPoints: MonoBehaviour
{

    public GameObject player;
    private int score = 0;

    void Start()
    {
        print(score);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
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
