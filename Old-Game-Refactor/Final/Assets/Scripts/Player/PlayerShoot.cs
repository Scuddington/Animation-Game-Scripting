using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerShoot : MonoBehaviour 
{
	public Rigidbody projectile;
	public float bulletSpeed = 15f;
	public int addBullet = 1;
	public int ammoValue = 1;

	public GameObject player;
	
	public PlayerHealth playerHealth;

	void Start()
	{
		playerHealth = player.GetComponent<PlayerHealth>();
	}

//Player shooting bullets
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && AmmoManager.ammo > 0)
		{
			Rigidbody instantiateProjectile = Instantiate (projectile, transform.position, transform.rotation)as Rigidbody;
			
			//instantiate bullet from PreFabs 
			
			instantiateProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, bulletSpeed));

			playerHealth.ShootBullet (addBullet);
			AmmoManager.ammo -= ammoValue;
		}		
	}	
}
