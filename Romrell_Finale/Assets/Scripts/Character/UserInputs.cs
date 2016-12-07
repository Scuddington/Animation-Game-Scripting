using UnityEngine;
using System;

public class UserInputs : MonoBehaviour
{
    PlayerMove playerMove;
    BulletShoot bulletShoot;
    public GameObject player;

    //Possibly the most inelegant solution
    void Start()
    {
        playerMove = player.GetComponent<PlayerMove>();
        bulletShoot = player.GetComponent<BulletShoot>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            playerMove.StartCoroutine(playerMove.Move()); 
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            bulletShoot.StartCoroutine(bulletShoot.Shoot());
        }
    }    
}
