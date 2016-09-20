using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	//Variables
	public int theForce = 0;

	private int middle = 2;
	
	//If Statements
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			NerfHerder ();
		}

		//Use LeftShift for this one
		if (Input.GetKeyDown (KeyCode.LeftShift)) 
		{
			int location = Random.Range (0, 4); 

			if (location > middle) 
			{
				print ("You're on the right.");
			} 

			else if (location < middle) 
			{
				print ("You're on the left.");
			}

			else
			{
				print ("You're in the middle.");
			}
		}
	}

	//Switch Statement
	void NerfHerder()
	{
		theForce = Random.Range (1, 8);

		switch (theForce) 
		{
		case 1:
			print ("The Force is strong with this one.");
			break;
		case 2: 
			print ("Luminous beings are we; not this crude matter.");
			break;
		case 3:
			print ("That's not how the Force Works!");
			break;
		default:
			print ("Uhhhhhhh");
			break;
		}
	}
}
