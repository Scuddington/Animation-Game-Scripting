using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletControl : MonoBehaviour {

    public List<Transform> bullets;
    public Transform bulletSpawn;
    public List<Rigidbody> bullet;

    private Vector3 bulletPos;

    //private Vector3 bulletPos;
    public float bulletSpeed = 5;
    public bool canShoot = false;

    private int bulletNum;
    
    void Start()
    {

        Bullets.SendBullet += BulletHandler;

        canShoot = true;

      
        //BulletSpawn.sendBulletSpawn += BulletSpawnHandler;
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

        //yield return new WaitForSeconds(2);

        //bullet[bulletNum].velocity = bulletPos * bulletSpeed * Time.deltaTime;
        //transform.Translate(bulletPos);
        //print("SHOOT HER! SHOOOOOOOOOOOOOT HERRRRRRR!");


        yield return null;
    }

    //public IEnumerator Shoot()
    //{
    //    while (canShoot)
    //    {

    //        yield return new WaitForSeconds(0.1f);



    //        bullet[bulletNum].velocity = bulletPos * bulletSpeed * Time.deltaTime;
    //        print("SHOOT HER! SHOOOOOOOOOOOOOT HERRRRRRR!");
    //        //transform.Translate(bulletPos);
    //        yield return null;
    //    }
    //}
}
