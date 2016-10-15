using UnityEngine;
using System.Collections;

public class EnemyFollow2 : MonoBehaviour {
	
//	public float interpVelocity;
//	public GameObject target;
//	public float speed = 0.2f;
//	Vector3 targetPos;
	
	
	// Update is called once per frame
	void Start () 
	{
//		target = GameObject.FindWithTag ("Player");
	}
	
	//enemy turns toward player when player enters sphere volume
	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player" && HealthManager.health > 0)
		{
			Debug.Log ("Moving");
//			Vector3 posNoZ = transform.position;
			transform.LookAt(col.gameObject.transform.position);
			//transform.Translate (col.gameObject.transform.position);
//			Vector3 posNoZ = new Vector3(targetPos.x, transform.position.y, targetPos.z);
//			
//			Vector3 targetDirection = (target.transform.position - posNoZ);
//			
////			interpVelocity = targetDirection.magnitude * 1f;
//			
//			targetPos = transform.position + (targetDirection.normalized * targetDirection.magnitude * Time.deltaTime); 
//			
			transform.position = Vector3.Lerp (transform.position, col.gameObject.transform.position, 0.025f);
//			
			// Rotate the camera every frame so it keeps looking at the target 

		}
	}
}