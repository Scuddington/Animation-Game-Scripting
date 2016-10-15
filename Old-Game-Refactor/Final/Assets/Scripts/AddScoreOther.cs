﻿using UnityEngine;
using System.Collections;

public class AddScoreOther : MonoBehaviour {

	public int scoreValue = 10;
	private GameObject player;
	public GameObject leaf;
	
	void Start()
	{
	player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player)
		{
			ScoreManager.score += scoreValue;
			DestroyObject (leaf);
		}
	}

}