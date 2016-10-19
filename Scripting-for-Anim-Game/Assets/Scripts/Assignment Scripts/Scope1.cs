using UnityEngine;
using System.Collections;

public class Scope1 : MonoBehaviour {

	////buckets can be accessed anywhere and can be see and changed in inspector
	//public int buckets = 2;
	////hats can only be accessed in this script
	//private int hats = 2;

	////Call for second script Scope2, allowing it to be accessed inside this script
	//Scope2 DisablePrint;

	//// Use this for initialization
	//void Start () 
	//{
	//	//set second script as object
	//	DisablePrint = GetComponent<Scope2> ();
	//}
	
	//// Update is called once per frame
	//void Update () 
	////Everything inside these curly brackets is part of the scope of this Update function
	//{
	//	if (Input.GetKeyDown (KeyCode.Space)) 
	//	{
	//		//disable second script that prints
	//		DisablePrint.enabled = false;
	//	}
	//}
}
