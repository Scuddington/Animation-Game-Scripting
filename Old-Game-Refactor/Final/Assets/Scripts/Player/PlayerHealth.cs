﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	//health variables
	public int startingHealth = 100; 
	public int currentAmmo;
	//ammo variables
	public int startingAmmo = 0; 
	public int currentHealth;
	//score variables
	public int startingScore = 0;
	public int currentScore;

	public Slider healthSlider;       //Reference to the UI's health bar
	public Slider ammoSlider;
	public Image damageImage;
	
	
	public GameObject gameOver;
	public GameObject youWin;
	
	PlayerMove02 playerMove;

	//enemy stuff to be disabled


	public float flashSpeed = 5f;

	public Color flashColor = new Color (1f, 0f, 0f, 0.1f);
		
	bool isDead;
	bool damaged;


	void Awake ()
	{
		playerMove = GetComponent<PlayerMove02>();

		currentAmmo = startingAmmo;

		currentHealth = startingHealth;

		currentScore = startingScore;
	}


	
	// Update is called once per frame
	void Update () 
	{
		if (damaged) 
		{
			damageImage.color = flashColor;
		} 
		else 
		{
			damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}

		damaged = false;
	}

	public void TakeDamage (int amount)
	{
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead) 
		{
			Death();
			
			gameOver.SetActive (true);
		}				
	}

	
	void Death()
	{
		isDead = true;
		
		playerMove.enabled = false;
	}

	//get health when you collide with Health Pickup
	public void GetHealth (int amount)
	{
		currentHealth += amount;
		healthSlider.value = currentHealth;
	}

	//get ammo when you collide with Ammo Pickup
	public void GetAmmo (int amount)
	{
		currentAmmo += amount;
		ammoSlider.value = currentAmmo;
	}

	public void ShootBullet (int amount)
	{
		currentAmmo -= amount;
		ammoSlider.value = currentAmmo;
	}

	public void AddScore (int amount)
	{
		currentScore += amount;

		if (currentScore >= 900) 
		{
			youWin.SetActive (true);
		}
	}
	
}
