using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	private int ThisBeANumber = 10;

	// Use this for initialization
	void Update () 
	{		
		if (Input.GetKeyDown(KeyCode.Space) && (ThisBeANumber > 0)) 
		{
			ThisBeANumber--;
			ThisBeAFunction ();
		}
	}
	
	// Update is called once per frame
	void ThisBeAFunction () 
	{
		print (ThisBeANumber);

		if (ThisBeANumber <= 0) 
		{
			print ("It's done, stop pressing Space.");
		}
	}
}
