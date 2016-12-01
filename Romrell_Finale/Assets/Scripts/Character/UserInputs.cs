using UnityEngine;
using System;

public class UserInputs : MonoBehaviour
{
    //public static Action<Input> UserInput;
    PlayerMove playerMove;
    public GameObject player;

    //Possibly the most inelegant solution
    void Start()
    {
        playerMove = player.GetComponent<PlayerMove>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            print("GOOOOO");
            playerMove.StartCoroutine(playerMove.Move()); 
        }
    }
    
}
