using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float cameraSpeed = 1;
    private Vector3 cameraPos;

	// Use this for initialization
	
	IEnumerator MoveCamera()
    {
        yield return new WaitForSeconds(1);
        cameraPos.y = cameraSpeed * Time.deltaTime;
        transform.Translate(cameraPos);
        print("Bwah");
    }

    void Start()
    {
        StartCoroutine(MoveCamera());
    }
}
