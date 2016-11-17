using UnityEngine;
using System.Collections;

public class MeleeHit : MonoBehaviour {

    public GameObject impactParticle;

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
}
