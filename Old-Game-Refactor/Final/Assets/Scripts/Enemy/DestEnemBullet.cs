using UnityEngine;
using System.Collections;

public class DestEnemBullet : MonoBehaviour {

	public float bullet = 2.0f;
	
	//Shooting
	void OnCollisionEnter (Collision col) 
	{
		if (col.gameObject.tag == "wall")
			Destroy (gameObject);
		else if (col.gameObject.tag == "Player")
			Destroy (gameObject);
		else
			Destroy (gameObject, bullet);
		
	}
}
