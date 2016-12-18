using UnityEngine;
using System.Collections;


public class Coroutines : MonoBehaviour {

    private Vector3 playerPos;
    private CharacterController playerCC;
    public int speed = 20;
    public GameObject RedSphere;
    public GameObject YellowSphere;
    private bool RedSphereOn = false;

    void Start()
    {
        RedSphere.SetActive(false);
        playerCC = gameObject.GetComponent<CharacterController>();
    }

	void Update ()
    {
	    if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            StartCoroutine(Move());
        }
	}

    void OnTriggerEnter()
    {
        StartCoroutine(InTrigger());

        if (RedSphereOn)
        {
            StartCoroutine(PickupPoint());
        }
    }

    //Sets YellowSphere to inactive, waits for 3 seconds, then turns on the RedSphere object and bool turns to true
    IEnumerator InTrigger()
    {
        print("Collided, wait for the red sphere");
        YellowSphere.SetActive(false);
        yield return new WaitForSeconds(3);
        RedSphere.SetActive(true);
        RedSphereOn = true;
    }

    //Move the character without having this information run in every frame
    IEnumerator Move ()
    {
        playerPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerCC.Move(playerPos * speed * Time.deltaTime);
        yield return null;  
    }

    //pickup point and set RedSphere to inactive
    IEnumerator PickupPoint()
    {
        print("pickup red point");
        RedSphere.SetActive(false);
        yield return null;
    }
}
