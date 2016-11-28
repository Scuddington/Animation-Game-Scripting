using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    public Transform player;

	void Update ()
    {
	    transform.position = new Vector3 (player.position.x, 14, player.position.z);
	}
}
