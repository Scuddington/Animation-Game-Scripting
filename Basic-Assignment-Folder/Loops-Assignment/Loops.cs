using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	private int forLoop;
	public int thisNumber;

	//made each loop a function, so that they can be called more than just at Start
	void Update()
	{
		
		int whileNumber = Random.Range (1, 3);
		thisNumber = whileNumber;

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			ForLoopFunction ();
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			WhileLoopFunction();
		}

		if (Input.GetKeyDown (KeyCode.D)) 
		{
			DoWhileLoopFunction ();
		}

		if (Input.GetKeyDown (KeyCode.F)) 
		{
			ForeachLoopFunction ();
		}
	}

	//FOR LOOP
	//prints the numbers 1 to 3
	void ForLoopFunction ()
	{
		int forNumber = 0;

		for (int i = 0; i < 3; i++) 
		{
			forNumber++;
			print (forNumber);
		}
	}

	//WHILE LOOP
	void WhileLoopFunction ()
	{
		print (thisNumber);
		while (thisNumber > 1) 
		{
			print ("While is running");
			print ("While is more than 2");
		}
//		while (randomNum > 3) 
//		{
//			print ("While loop running");
//			print (randomNum);
//		}
	}

	//DOWHILE LOOP
	void DoWhileLoopFunction()
	{
//		bool moving = true;
//					
//		do {
//			print ("Beep");
//		} while (moving == false);
	}

	//FOREACH LOOP
	void ForeachLoopFunction()
	{
		
//		string[] strings = new string[3];
//
//		strings[0] = "First string";
//		strings[1] = "Second string";
//		strings[2] = "Third string";
//
//		foreach(string item in strings)
//		{
//			print (item);
//		}

	}

}
