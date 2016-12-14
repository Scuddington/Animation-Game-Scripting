using UnityEngine;
using System.Collections;
using System;

public class EventManager : MonoBehaviour {

    public static Action<Transform> SendPlayer;


    void Start()
    {
        if (SendPlayer != null)
        {
            SendPlayer(transform);
        }

    }
}
