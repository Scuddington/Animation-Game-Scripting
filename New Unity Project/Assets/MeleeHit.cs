using UnityEngine;
using System.Collections;

public class MeleeHit : MonoBehaviour {

    public GameObject impactParticle;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
            Instantiate(impactParticle, contact.point, Quaternion.identity);
    }
}
