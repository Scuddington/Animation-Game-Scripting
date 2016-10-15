using UnityEngine;
using System.Collections;

public class DeathRespawn : MonoBehaviour {

	public GameObject respawnpoint;
	public GameObject player;
	
	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "bullet") 
		{
			StartCoroutine(respawn());
		}
	}
	
	IEnumerator respawn()
	{
		yield return new WaitForSeconds (0.5f);
		
		player.transform.position = respawnpoint.transform.position;
	}
}