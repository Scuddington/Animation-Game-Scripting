using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    public Transform player;
    private bool playerMoving = false;
    UserInputs userInputs;

    //Camera follows without update by using coroutine
    //It's brute force and would slow down a real game to start with a while loop like this
    void Start ()
    {
        playerMoving = true;
        StartCoroutine(CameraFollow());
    }

    //Camera follows when playerMoving = true, and it's always true in this case, so it always follows
    IEnumerator CameraFollow()
    {
        while (playerMoving)
        {
            transform.position = new Vector3(player.position.x, player.position.y + 14, player.position.z);
            yield return null;
        }
    }
}
