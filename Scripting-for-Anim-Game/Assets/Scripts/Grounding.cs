using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Grounding : MonoBehaviour {

    public Vector3 startPoint;
    private CharacterController cc;
    private float gravity = 5;
    private Vector3 tempP;

	// Use this for initialization
	void Start ()
    {
        //gravity *= -1;
        startPoint = transform.position;
        cc = GetComponent<CharacterController>();
    }
	
    void OnTriggerEnter ()
    {
        transform.position = startPoint;
    }
	// Update is called once per frame
	void Update ()
    {
        tempP.y = -gravity;
        cc.Move(tempP * Time.deltaTime);
        if (cc.isGrounded)
        {
            tempP.x = gravity* 2;
        }
        //else
        //{
        //    tempP.x = 0;
        //}
	}
}
