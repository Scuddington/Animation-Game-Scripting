using UnityEngine;
using System.Collections;

public class HotPockets : MonoBehaviour {

	private int neutralScum = 2;

	//LONG LIVE THE EMPEROR
		
	// Update is called once per frame
	void Update () 

	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			int loyaltyMeter = Random.Range (0, 4); 

			//print (loyaltyMeter);

			if (loyaltyMeter > neutralScum) 
			{
				print ("The Emperor would be proud.");
			} 

			else if (loyaltyMeter < neutralScum) 
			{
				print ("You Rebel scum.");
			}

			else
			{
				print ("You nerf herder, pick a side!");
			}
		}
	}		
}
