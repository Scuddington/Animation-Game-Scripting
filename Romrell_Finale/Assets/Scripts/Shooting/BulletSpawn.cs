using UnityEngine;
using System.Collections;
using System;

public class BulletSpawn : MonoBehaviour {

    public static Action<Transform> sendBulletSpawn;

	void Start ()
    {
	    if (sendBulletSpawn != null)
        {
            sendBulletSpawn(transform);
        }
	}
	
}
