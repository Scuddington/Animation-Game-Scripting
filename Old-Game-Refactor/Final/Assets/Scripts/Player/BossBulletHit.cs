using UnityEngine;
using System.Collections;

public class BossBulletHit : MonoBehaviour {
	
	//	int bulletDamage = 5;
	//	public GameObject bullet;
	public GameObject boss;
	public int scoreValue = 50;
	//	public int scoreUp = 50;
	
	public GameObject bullet;
	
	ScoreManager scoreManager;
	//	PlayerHealth playerHealth;
	
	
	
	void Start()
	{
		//		bullet = GameObject.FindGameObjectWithTag ("projectile");
		//		enemy = GameObject.FindGameObjectWithTag ("Enemy");
	}
	
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "projectile") 
		{
			
			//			enemy.gameObject.SetActive (false);
			DestroyObject (boss); 
			//			print ("Holy crap I'm frustrated");
			//			playerHealth.AddScore (scoreUp);
			ScoreManager.score += scoreValue;
			
		}
	}
}
