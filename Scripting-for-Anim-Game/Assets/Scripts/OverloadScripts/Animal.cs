using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    public virtual void Start ()
    {
        Walk();
    }

    void Walk()
    {
        print("Walking");
    }
}
