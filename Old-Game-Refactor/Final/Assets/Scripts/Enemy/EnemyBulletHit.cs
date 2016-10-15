using UnityEngine;
using System.Collections;

public class EnemyBulletHit : MonoBehaviour {

	public int bulletDamage = 10;
	public int healthValue = 10;
	public GameObject player;
	PlayerHealth playerHealth;

	void Start()
	{
		//LAST TAG: working on a fix
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject == player) 
		{
			playerHealth.TakeDamage (bulletDamage);
			HealthManager.health -= healthValue;
		}
	}
}
