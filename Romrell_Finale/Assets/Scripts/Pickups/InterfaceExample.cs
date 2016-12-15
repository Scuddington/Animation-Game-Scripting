using UnityEngine;
using System.Collections;

public class InterfaceExample : PickupColor {

    //overriding the Interface of PickupColor while still inheriting Monobehavior OnTriggerEnter from PickupColor
	void OnTriggerEnter()
    {
        print("Psych! I'm a decoy.");
        gameObject.SetActive(false);
    }
}
