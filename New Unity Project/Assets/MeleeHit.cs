﻿using UnityEngine;
using System.Collections;

public class MeleeHit : MonoBehaviour {

    public GameObject impactParticle;
    //public GameObject Player;

//	private bool hasCollided = false;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
            Instantiate(impactParticle, contact.point, Quaternion.identity);

//		if (!hasCollided)
//		{
//			hasCollided = true;
//			Destroy (impactParticle);
//		}
    }

   
    //Cheaty Script for Prototype
    //void OnCollisionEnter(Collision collision)
    //{
    //    //foreach (ContactPoint contact in collision.contacts)
    //    Instantiate(impactParticle, Player.transform.position, Quaternion.identity);

    //    //		if (!hasCollided)
    //    //		{
    //    //			hasCollided = true;
    //    //			Destroy (impactParticle);
    //    //		}
    //}
}
