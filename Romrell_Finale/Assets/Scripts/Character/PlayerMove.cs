using UnityEngine;
using System.Collections;
using System;

public class PlayerMove : MonoBehaviour {

    private Vector3 playerPos;
    private CharacterController playerCC;
    public int speed = 20;

	void Start ()
    {
        playerCC = GetComponent<CharacterController>();
    }

    //OLD THINGY
    //void Update()
    //{
    //    if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
    //    {
    //        StartCoroutine(Move());
    //    }
    //}

    //movement Coroutine being called in UserInputs
    public IEnumerator Move ()
    {
        print("move coroutine running");
        playerPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerCC.Move(playerPos * speed * Time.deltaTime);
        yield return null;
    }
}
