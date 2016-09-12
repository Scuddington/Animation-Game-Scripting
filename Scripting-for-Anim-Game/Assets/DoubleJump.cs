using UnityEngine;
using System.Collections;

public class DoubleJump : MonoBehaviour {

    //character Speed
    public float speed = 5;
    //Character controller component
    private CharacterController myCC;
    //temp var of data type Vector3 to move the character
    private Vector3 TempPos;
    private float gravity = 1f;
    public float jumpSpeed = 15f;
    public int jumpCount = 0;
    public int jumpCountMax = 1;

	// Use this for initialization
	void Start ()
    {
        //This find teh character controller
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //TempPos.y = gravity
        //Double jump
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {
            //incrementing jump count by 1
            jumpCount++;
            //Adding the jumpSpeed to the character
            TempPos.y = jumpSpeed;
        }
        //Test if character is grounded, and reset jumpCount if it is
        if (myCC.isGrounded)
        {
            //resets jumpCount to 0
            jumpCount = 0;
        }

        //Adding gravity to the y position of the tempPos
        TempPos.y -= gravity;

        //Move character on x-axis
        TempPos.x = speed * Input.GetAxis("Horizontal");
        //Move character on z-axis
        TempPos.z = speed * Input.GetAxis("Vertical");
        //move at consistent speed using (Time.deltaTime)
        myCC.Move(TempPos * Time.deltaTime);
	}
}
