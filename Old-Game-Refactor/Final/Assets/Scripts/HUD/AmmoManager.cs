using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public static int ammo;
	public Slider ammoSlider; 
	AmmoManager ammoManager;

	Text text;
	
	void Awake()
	{
		//text reference
		text = GetComponent <Text> ();
		//reset score
		ammo = 0;
	}
	
	void Update () 
	{
		text.text = "Ammo: " + ammo + "/20";
	}
}