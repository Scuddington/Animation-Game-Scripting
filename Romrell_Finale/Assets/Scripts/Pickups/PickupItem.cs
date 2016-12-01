using UnityEngine;
using System.Collections;

public class PickupItem : MonoBehaviour {

    private GameObject PickupMat;

    //Material on player changes when it collides with pickup
    void OnTriggerEnter(Collider PickupMat)
    {
        //gameObject.GetComponent<Renderer>().material = PickupMat.GetComponent<Renderer>().material;
        PickupMat.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
    }
}
