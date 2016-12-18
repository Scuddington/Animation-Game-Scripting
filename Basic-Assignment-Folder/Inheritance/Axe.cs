using UnityEngine;
using System.Collections;

public class Axe : Weapons {

    public GameObject AxeObject;

    //I can use the Input from Weapons in here to make the axe disappear, 
    //because it is inheriting the Update function in Weapons
    public override void Inventory()
    {
        base.Inventory();
        print("But no axe");
        AxeObject.SetActive(false);
    }
}
