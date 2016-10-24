using UnityEngine;
using System.Collections;

public class DestroyStars : MonoBehaviour {

    public float endStarTime = 3;

	void OnCollisionEnter ()
    {
        Destroy(gameObject, endStarTime);
    }

    //IEnumerator EndStarSpawn()
    //{
    //    yield return new WaitForSeconds(endStarTime);
    //}
}
