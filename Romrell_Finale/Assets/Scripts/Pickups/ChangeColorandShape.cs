using UnityEngine;
using System.Collections;

public class ChangeColorandShape : PickupColor {

    //no variables or gameobjects declared because they are inheriting from PickupColor.
    //Even the OnTriggerEnter in PickupColor is being used in this script
    //no need to declare any kind of variables or gameobjects
    //really useful in this instance, because I can just put this script on any of my pickups, 
    //without having to drag the gameObject over to get the material
}
