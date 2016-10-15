using UnityEngine;
using System.Collections;

public class CamTopDown : MonoBehaviour {
		
	public Transform player;
		
	//Camera follow from +20 above the player
	void Update ()
	{
		transform.position = new Vector3 (player.position.x + 0, player.position.y + 25, player.position.z + 0);
	}
}
