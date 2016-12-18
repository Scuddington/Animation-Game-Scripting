using UnityEngine;
using System.Collections;

//this is the base class, from with Sword and Axe inherit
public class Weapons : MonoBehaviour {

    //virtual void enables me to override it in the Sword and Axe scripts
    public virtual void Inventory()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inventory();
        }
    }
}
