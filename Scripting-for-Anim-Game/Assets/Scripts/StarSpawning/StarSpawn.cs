using UnityEngine;
using System.Collections;

public class StarSpawn : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] stars;
    public float spawnTimer = 1;
    public bool canSpawnStars = true;

    private int i = 0;
    private int j = 0;

    IEnumerator SpawnStars()
    {
        while (canSpawnStars)
        {
            i = Random.Range(0, spawnPoints.Length - 1);
            stars[j].SetActive(true);
            stars[j].transform.position = spawnPoints[i].position;

            if (j < stars.Length - 1)
            {
                j++;
            } else
            {
                j = 0;
            }

            //print(spawnPoints.Length);
            //Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTimer);
        }
    }

	void Start ()
    {
        StartCoroutine(SpawnStars());
	}
	
}
