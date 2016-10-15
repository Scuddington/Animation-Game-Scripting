using UnityEngine;
using System.Collections;

public class EnemyFollow2 : MonoBehaviour {

	public GameObject player;
	
	//enemy turns toward player when player enters sphere volume
	void OnTriggerStay(Collider col)
	{
		if (col.gameObject == player && HealthManager.health > 0)
		{
			transform.LookAt(col.gameObject.transform.position);
			transform.position = Vector3.Lerp (transform.position, col.gameObject.transform.position, 0.025f);
		}
	}
}