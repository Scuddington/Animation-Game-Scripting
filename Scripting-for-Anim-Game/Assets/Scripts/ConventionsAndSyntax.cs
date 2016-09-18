using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour {

	//You can comment out anything you want with two forward slashes

	public int ImAVariable = 2;


	//You can comment out multiple lines of code with a forward slash and asterisk

	/*
	void UselessFunction()
	{
		print ("My sole purpose is to be commented out. Woe is me.");
	}
	*/

	void SomethingSomethingFunction ()
	{
		print ("Look at me go!");
	}


	// Use this for initialization
	void Start () 
	{
		SomethingSomethingFunction ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ImAVariable >= 0 && ImAVariable <= 50) 
		{
			ImAVariable++;
			print (ImAVariable);
			print ("Beep boop I'm numbers and I'm going up!");
		}
	}

}
