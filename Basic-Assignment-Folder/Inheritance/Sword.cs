using UnityEngine;
using System.Collections;

public class Sword : Weapons {

    //Using override, I can use the same function type without completely overriding everything in Weapons.
    //If I just used a normal void, this class's Inventory would override the one in weapons,
    //and I couldn't see both print statements 
    public override void Inventory()
    {
        base.Inventory();
        print("I have a sword");
    }
}
