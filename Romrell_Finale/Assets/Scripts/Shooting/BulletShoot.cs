﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletShoot : MonoBehaviour {

    public List<Transform> bullets;
   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public IEnumerator Shoot () {
        print("SHOOT HER");

        yield return null;
	}
}
