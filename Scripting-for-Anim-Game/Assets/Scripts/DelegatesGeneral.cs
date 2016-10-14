using UnityEngine;
using System.Collections;
using System;

public class DelegatesGeneral : MonoBehaviour {

    Action<DelegatesGeneral> Move;
    Action Idle;
    Action Jump;

    int speed = 200;

    void MoveHandler(DelegatesGeneral obj)
    {
        print("Moving at " + obj.speed + " miles per hour");
        Move = null;
        Idle = IdleHandler;
    }
    void IdleHandler()
    {
        print("Idling");
        Idle = null;
        Jump = JumpHandler;
    }
    void JumpHandler()
    {
        print("Jumping");
        Jump = null;
    }

    void Start ()
    {
        Move = MoveHandler;
        //Idle = IdleHandler;
        //Jump = JumpHandler;
    }

    void Update ()
    {
        if (Move != null)
            Move(this);
        if (Idle != null)
            Idle();
        if (Jump != null)
            Jump();
    }
}
