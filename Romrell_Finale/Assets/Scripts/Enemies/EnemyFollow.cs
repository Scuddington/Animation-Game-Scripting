using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
