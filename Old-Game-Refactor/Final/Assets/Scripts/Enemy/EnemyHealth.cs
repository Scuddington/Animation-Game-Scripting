using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public GameObject Enemy;
	public int currentEnemyHealth;
	public int enemyHealth = 15;
//	public Slider enemyHealthSlider;

	bool isDead;


	void Awake () 
	{
		currentEnemyHealth = enemyHealth;
	}


	public void EnemyTakeDamage (int amount)
	{
		enemyHealth -= amount;
//		enemyHealthSlider.value = currentEnemyHealth;
		
		if (enemyHealth <= 0) 
		{
			DestroyObject (Enemy);
		}
	}

//	void Death()
//	{
//		isDead = true;
//
//		DestroyObject (Enemy);
//	}
}
