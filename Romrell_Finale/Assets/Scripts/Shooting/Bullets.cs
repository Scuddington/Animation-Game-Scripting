using UnityEngine;
using System.Collections;
using System;

public class Bullets : MonoBehaviour {

    public static Action<Transform> SendBullet;

    //public float bulletSpeed = 5;
    //private Vector3 bulletPos;

    void Start ()
    {
	    if (SendBullet != null)
        {
            SendBullet(transform);
        }

	}

    //public IEnumerator Shoot()
    //{
        

    //    bulletPos.x = bulletSpeed * Time.deltaTime;
    //    //transform.Translate(bulletPos);
    //    print("SHOOT HER! SHOOOOOOOOOOOOOT HERRRRRRR!");
    //    yield return new WaitForSeconds(2);

        
    //    SendBullet(transform);
    //    print("return to sender");
        
    //}
}
