using UnityEngine;
using System.Collections;

public class InterfaceExample : PickupColor {

    //overriding the Interface of PickupColor while still inheriting Monobehavior OnTriggerEnter from PickupColor
	void OnTriggerEnter()
    {
        print("Can't change to my color! I'm overriding the Interface of PickupColor!");
    }
}
