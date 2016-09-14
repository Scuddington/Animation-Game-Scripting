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
    //Slide vars
    public int slideDuration = 10;
    public float slideTime = 0.01f;
   
    
    //Coroutine for sliding character
    IEnumerator Slide ()
    {
        //set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float speedTemp = speed;
        
        //While loop runs while the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            //decrement slideDuration by 1
            slideDuration--;
            //Yield "holds" the coroutine
            //return "sends" a signal to the coroutine to do an operation while yielding
            //new creates an instanceof an object
            //WaitForSeconds is an object that waits for the amount of seconds indicated (can be a variable as well as numbers)
            yield return new WaitForSeconds(slideTime);
            speed += speed;

        }
        speed = speedTemp;
        slideDuration = durationTemp;
    }

    // Use this for initialization
    void Start ()
    {
        //This finds the character controller
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

        //Start sliding
        if (Input.GetKey(KeyCode.D) && (Input.GetKeyDown(KeyCode.LeftShift)))
        {
            //StartCoroutine is a function that calls a coroutine. Use coroutine in the argument
            StartCoroutine(Slide());
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKeyDown(KeyCode.LeftShift)))
        {
            //StartCoroutine is a function that calls a coroutine. Use coroutine in the argument
            StartCoroutine(Slide());
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
