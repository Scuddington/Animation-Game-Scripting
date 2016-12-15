using UnityEngine;
using System.Collections;
using System;

public class SendPlayer : MonoBehaviour
{
    public static Action<Transform> SendPlayerTo;

    // Use this for initialization
    void Start()
    {
        if (SendPlayerTo != null)
        {
            SendPlayerTo(transform);
        }
    }
}