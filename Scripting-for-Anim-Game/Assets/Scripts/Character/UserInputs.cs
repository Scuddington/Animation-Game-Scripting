using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour
{

    public static Action<KeyCode> UserInput;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) && UserInput != null)
        {
            UserInput(KeyCode.A);
        }
        if (Input.GetKeyDown(KeyCode.D) && UserInput != null)
        {
            UserInput(KeyCode.D);
        }
    }
}
