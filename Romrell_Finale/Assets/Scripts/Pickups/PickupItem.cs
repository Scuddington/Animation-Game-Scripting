using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupItem : MonoBehaviour {

    private GameObject PickupMat;
  
    //Material on player changes when it collides with pickup
    void OnTriggerEnter(Collider PickupMat)
    {
        PickupMat.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
    }
}
