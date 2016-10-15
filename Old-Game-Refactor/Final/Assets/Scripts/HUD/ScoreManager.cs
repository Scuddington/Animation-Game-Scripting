using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;
	
	Text text;
	
	void Awake()
	{
		//text reference
		text = GetComponent <Text> ();
		
		//reset score
		score = 0;
	}
	
	
	void Update () 
	{
		text.text = "Score: " + score + "/900";
	}
}
