using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {


    private CharacterController myCC;
    //Temp variable of datatype vector3 to move character
    private Vector3 tempPos;
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            tempPos.y = jumpSpeed;
        }

        tempPos.y -= gravity;

        tempPos.x = speed*Input.GetAxis("Horizontal");
        
        //tempPos.y = speed * Input.GetAxis("Vertical");
        myCC.Move (tempPos * Time.deltaTime);
	}
}
