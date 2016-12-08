using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletControl : MonoBehaviour {

    public List<Transform> bullets;
    public Transform bulletSpawn;

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

        if (bulletNum < bullets.Count - 1)
        {
            bulletNum++;
            canShoot = true;
        }
        else
        {
            bulletNum = 0;
        }

        //yield return new WaitForSeconds(2);

        //bullets[bulletNum].position = bulletPos * bulletSpeed * Time.deltaTime;
        //transform.Translate(bulletPos);
        //print("SHOOT HER! SHOOOOOOOOOOOOOT HERRRRRRR!");


        yield return null;
    }

    public IEnumerator Shoot()
    {
        while (canShoot)
        {
            yield return new WaitForSeconds(0.1f);
            print("SHOOT HER! SHOOOOOOOOOOOOOT HERRRRRRR!");


            bullets[bulletNum].position = bulletSpawn.position * bulletSpeed * Time.deltaTime;
            //transform.Translate(bulletPos);
            yield return null;
        }
    }
}
