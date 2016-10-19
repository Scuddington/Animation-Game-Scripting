using UnityEngine;
using System.Collections;
using System;

public class SendRight : MonoBehaviour {

    public static Action<GameObject> SendThis;

	// Use this for initialization
	void Start () {
        SendThis(gameObject);
	}
}
