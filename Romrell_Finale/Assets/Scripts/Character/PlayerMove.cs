using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    private Vector3 playerPos;
    private CharacterController playerCC;
    public int speed = 20;

	// Use this for initialization
	void Start ()
    {
        playerCC = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            StartCoroutine(Move());
        }
	}

    IEnumerator Move ()
    {
        //playerPos.x = speed * Input.GetAxis("Horizontal");
        playerPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerCC.Move(playerPos * speed * Time.deltaTime);
        yield return null;
    }
}
