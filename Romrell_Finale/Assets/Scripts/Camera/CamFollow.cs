using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    public Transform player;
    public bool playerMoving = false;

    //Camera follows without update by using coroutine
    void Start ()
    {
        playerMoving = true;
        StartCoroutine(CameraFollow());
    }


	IEnumerator CameraFollow ()
    {
        while (playerMoving)
        {
            transform.position = new Vector3(player.position.x, player.position.y + 14, player.position.z);
            print("camera moving");
            yield return null;
        }
	}
}
