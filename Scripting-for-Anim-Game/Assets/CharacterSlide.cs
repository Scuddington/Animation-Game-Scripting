using UnityEngine;
using System.Collections;

public class CharacterSlide : MonoBehaviour {


    private CharacterController myCC;
    public int slideDuration = 10;
    public float slideTime = 0.01f;

    IEnumerator Slide()
    {
        int i = 0;
        //while iterations
        //wait for seconds
        //move the character controller
        while(i < slideDuration)
        {
            i++;
            yield return new WaitForSeconds(slideTime);
            print("SLIDING, AAHHHHHH!");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
