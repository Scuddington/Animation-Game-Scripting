using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour {

//	int bulletDamage = 5;
//	public GameObject bullet;
	public GameObject enemy;
	public int scoreValue = 50;
	public int scoreUp = 50;

	public GameObject bullet;

	ScoreManager scoreManager;
	PlayerHealth playerHealth;



	void Start()
	{
//		bullet = GameObject.FindGameObjectWithTag ("projectile");
//		enemy = GameObject.FindGameObjectWithTag ("Enemy");
		playerHealth = GameObject.Find ("Player").GetComponent<PlayerHealth>();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "projectile") 
		{
						
//			enemy.gameObject.SetActive (false);
			DestroyObject (enemy); 

			playerHealth.AddScore (scoreValue);
			ScoreManager.score += scoreValue;
			
		}
	}
}