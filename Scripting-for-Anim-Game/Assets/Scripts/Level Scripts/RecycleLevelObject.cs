using UnityEngine;
using System.Collections;

public class RecycleLevelObject : MonoBehaviour {

    private Vector3 newLocation;

	void OnTriggerEnter()
    {
        newLocation.x = StaticVars.nextSectionPos;
        transform.position = newLocation;
        StaticVars.nextSectionPos += StaticVars.distance;
        print("I'm hit!");
    }

}
