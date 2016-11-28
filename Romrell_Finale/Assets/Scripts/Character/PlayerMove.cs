using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    private Vector3 playerPos;
    private CharacterController playerCC;
    public int speed = 2;

	// Use this for initialization
	void Start ()
    {
        playerCC = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            StartCoroutine(Move());
        }
	}

    IEnumerator Move ()
    {
        playerPos.x = speed * Input.GetAxis("Horizontal");
        playerCC.Move(playerPos * Time.deltaTime);
        yield return null;
    }
}
