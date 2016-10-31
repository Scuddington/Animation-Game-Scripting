using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarControl2 : MonoBehaviour {

    public List<Transform> spawners;
    public List<Transform> stars;

    private int starNum;
    private int spawnerNum;

    private bool canSpawn = true;

    void SpawnHandler (Transform _t)
    {
        spawners.Add(_t);
    }

    void StarHandler(Transform _t)
    {
        stars.Add(_t);
    }
    // Use this for initialization
    void Start ()
    {
        StarSpawner2.SendSpawner += SpawnHandler;
        Star.SendStar += StarHandler;
        if (stars != null || spawners != null)
            StartCoroutine(Spawn());
	}

    IEnumerator Spawn ()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(1);
            stars[starNum].position = spawners[spawnerNum].position;
            stars[starNum].GetComponent<MeshRenderer>().enabled = true;
            if (starNum < stars.Count - 1)
            {
                starNum++;
            } else
            {
                starNum = 0;
            }

            if (spawnerNum < spawners.Count - 1)
            {
                spawnerNum++;
            }
            else
            {
                spawnerNum = 0;
            }
        }
    }

}
