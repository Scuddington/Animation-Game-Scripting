using UnityEngine;
using System.Collections;

public class CamTopDown : MonoBehaviour 
	{
		public Transform player;
		
		//find player
		void Start()
		{
			player = GameObject.FindGameObjectWithTag ("Player").transform;
		}
		
		//Camera follow from +20 above the player
		void Update ()
		{
			transform.position = new Vector3 (player.position.x + 0, player.position.y + 25, player.position.z + 0);
		}
		
	}
