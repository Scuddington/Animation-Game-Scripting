using UnityEngine;
using System;

public class UserInputs : MonoBehaviour
{
    PlayerMove playerMove;
    BulletControl bulletControl;
    Bullets bulletShoot;
    public GameObject player;
   // public GameObject bullet;

    //Possibly the most inelegant solution
    void Start()
    {
        //To get coroutines in player
        playerMove = player.GetComponent<PlayerMove>();
        bulletControl = player.GetComponent<BulletControl>();

        //To get coroutine in bullets to move them
        //bulletShoot = bullet.GetComponent<Bullets>();  
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            playerMove.StartCoroutine(playerMove.Move()); 
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            bulletControl.StartCoroutine(bulletControl.MoveBulletToSpawn());
            //bulletControl.StartCoroutine(bulletControl.Shoot());
            //bulletShoot.StartCoroutine(bulletShoot.Shoot());
        }
    }    
}
