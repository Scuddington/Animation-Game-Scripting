using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public int healthValue = 20;
	public int addHealth = 20;
	public GameObject player;
	public GameObject health;
	PlayerHealth playerHealth;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player && HealthManager.health < 100)
		{
			playerHealth.GetHealth (addHealth);
			HealthManager.health += healthValue;
//			DestroyObject (health);
			StartCoroutine(DisableHealth());

			if (HealthManager.health > 100)
			{
				HealthManager.health = 100;
			}
		}
	}
	
	IEnumerator DisableHealth()
	{
		health.gameObject.SetActive (false);
		yield return new WaitForSeconds(5);
		health.gameObject.SetActive (true);
	}	
}
