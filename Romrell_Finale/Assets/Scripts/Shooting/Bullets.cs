using UnityEngine;
using System.Collections;
using System;

public class Bullets : MonoBehaviour {

    public static Action<Transform> SendBullet;

    void Start ()
    {
	    if (SendBullet != null)
        {
            SendBullet(transform);
        }
	}
}
