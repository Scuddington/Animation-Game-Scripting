using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public Rigidbody projectile;
	public float bulletSpeed = 1f;
	public float InstantiationTimer = .5f;

	int maxRange = 8;
	public Transform target;

	//Instantiate bullet when player enters enemy range
	void Update () 
	{
		if (Vector3.Distance (transform.position, target.position) < maxRange && HealthManager.health > 0) 
		{
			if (InstantiationTimer > 0) 
			{
				InstantiationTimer -= Time.deltaTime;
			}
			else
			{
				Rigidbody instantiateProjectile = Instantiate (projectile, transform.position, transform.rotation)as Rigidbody;
			
				//spawn new object every time timer reaches 0.5 seconds
				instantiateProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, bulletSpeed));
				InstantiationTimer = .5f;
			}				 
		}
	}
}
