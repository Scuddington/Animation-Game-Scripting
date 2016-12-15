using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletControl : MonoBehaviour {


    //was going to add shooting, but decided on a puzzle game
    public List<Transform> bullets;
    public Transform bulletSpawn;
    public List<Rigidbody> bullet;

    public bool canShoot = false;

    private int bulletNum;
    
    void Start()
    {
        Bullets.SendBullet += BulletHandler;

        canShoot = true;
    }

    void BulletHandler (Transform _b)
	{
		bullets.Add (_b);
	}



    public IEnumerator MoveBulletToSpawn()
    {

        bullets[bulletNum].position = bulletSpawn.position;
        //bulletPos = bulletSpawn.position;
        if (bulletNum < bullets.Count - 1)
        {
            bulletNum++;
            canShoot = true;
        }
        else
        {
            bulletNum = 0;
        }

        foreach (Transform bul in bullets)
        {
            print("You have " + bul + "bullets");
        }
        yield return null;
    }

}
