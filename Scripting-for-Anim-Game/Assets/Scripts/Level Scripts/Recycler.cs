using UnityEngine;
using System.Collections;
using System;

public class Recycler : MonoBehaviour {

    public static Action<Recycler> recycleAction;
    //bool default state is false
    public bool canBeRecycled = false;
    public Transform cube;

	// Use this for initialization
	void Start ()
    {
        cube = this.GetComponent<Transform> ();
        if (recycleAction != null && canBeRecycled != false)
        {
            recycleAction (this);
        }
	}

    void OnTriggerEnter()
    {
        canBeRecycled = true;
        Start();
    }
}
