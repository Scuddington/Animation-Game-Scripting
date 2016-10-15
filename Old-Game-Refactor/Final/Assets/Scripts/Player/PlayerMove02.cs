using UnityEngine;
using System.Collections;

public class PlayerMove02 : MonoBehaviour 
	
{
	public float speed = 8f;
	
		
	void Update()
		
	{				
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		
		
		//facing forward
		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
		{
			transform.forward = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		}		
	}	
}
