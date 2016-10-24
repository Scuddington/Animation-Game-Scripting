using UnityEngine;
using System.Collections;

public class CamFollowPlayer : MonoBehaviour {


    public Transform player;
	// Use this for initialization

	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3 (player.position.x, -3, -10);
	}
}
