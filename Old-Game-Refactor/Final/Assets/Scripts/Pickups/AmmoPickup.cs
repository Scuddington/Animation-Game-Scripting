using UnityEngine;
using System.Collections;

public class AmmoPickup : MonoBehaviour {

	public int ammoValue = 10;
	public int addAmmo = 10;
	private GameObject player;
	public GameObject ammo;
//	public int timeToWait = 5;
	AmmoManager ammoManager;
	PlayerHealth playerHealth;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player && AmmoManager.ammo < 20)
		{
			playerHealth.GetAmmo (addAmmo);
			AmmoManager.ammo += ammoValue;
					
			StartCoroutine(DeactivateAmmo());
//			DestroyObject (ammo);
				
			if (AmmoManager.ammo > 20)
			{
				AmmoManager.ammo = 20;
			}
		}
	}
	
	IEnumerator DeactivateAmmo()
	{
		ammo.gameObject.SetActive (false);
		
		yield return new WaitForSeconds (1);
		print ("Reactivate");		
//		ammo.gameObject.SetActive (true);
//		StartCoroutine (ReactivateAmmo());
		
	}
	
//	IEnumerator ReactivateAmmo()
//	
//		{	
//			ammo.gameObject.SetActive (true);
//		}	
}

