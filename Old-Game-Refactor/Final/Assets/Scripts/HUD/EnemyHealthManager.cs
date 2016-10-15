using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public static int health;
	
	Text text;
	
	void Awake()
	{
		//text reference
		text = GetComponent <Text> ();
		
		//reset score
		health = 20;
	}
	
	
	void Update () 
	{
		text.text = "Health: " + health;
	}
}