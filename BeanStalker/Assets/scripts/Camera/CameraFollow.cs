using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float cameraSpeed = 1;
    private Vector3 cameraPos;

	// Use this for initialization
	void Start ()
    {
        //MoveCamera();
	}
	
	IEnumerator MoveCamera()
    {
        cameraPos.y = cameraSpeed * Time.deltaTime;
        transform.Translate(cameraPos);
        print("Bwah");
    }
}
