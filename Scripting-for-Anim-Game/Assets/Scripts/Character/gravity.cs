using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

    CharacterController myCC;
    Vector3 tempPos;
    public float Gravity = 1;
    public float sideForce = 1;

	// Use this for initialization
	void Start () {
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempPos.y -= Gravity * Time.deltaTime;
        tempPos.z = sideForce;

        if(myCC.isGrounded)
        {
            tempPos.y = 0;
        }
        print(myCC.velocity);
        myCC.Move(tempPos);
	}
}
