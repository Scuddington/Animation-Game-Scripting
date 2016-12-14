using UnityEngine;
using System.Collections;
using System;

public class Teleport : MonoBehaviour {

    public Transform player;
    public Transform PurpleTeleport;

    void Update()
    {
        player.position = PurpleTeleport.position;
    }
}
