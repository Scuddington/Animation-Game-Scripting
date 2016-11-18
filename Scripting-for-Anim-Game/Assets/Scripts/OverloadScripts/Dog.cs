using UnityEngine;
using System.Collections;

public class Dog : Animal {

    public override void Start ()
    {
        base.Start();
        Bark();   
    }

	void Bark()
    {
        print("WOOF");
    }
}
