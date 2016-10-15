using UnityEngine;
using System.Collections;

public class EnemyBulletHit : MonoBehaviour {

	public int bulletDamage = 10;

	public int healthValue = 10;
	
	Animator anim;
	public GameObject player;
	PlayerHealth playerHealth;
	
	
	void Start()
	{
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
