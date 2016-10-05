using UnityEngine;
using System.Collections;

public class FlipArt : MonoBehaviour {
    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.A:
                if (forward){
                    characterArt.Rotate(0, 180, 0);
                    forward = false;
                    print("left");
                }
                break;

            case KeyCode.D:
                if (!forward) { 
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                    print("right");
                }
                break;
        }
        
        //forward = _b;
    }

    void StopScript()
    {
        UserInputs.UserInput -= FlipCharacter;
    }
    void Start ()
    {
        //EndGame.GameOver += StopScript;
        UserInputs.UserInput += FlipCharacter;
    }
}
