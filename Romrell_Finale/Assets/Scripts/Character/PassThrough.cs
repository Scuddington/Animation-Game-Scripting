using UnityEngine;
using System.Collections;

public class PassThrough : MonoBehaviour {

    public GameObject wallColor;
    public GameObject playerColor;
    private Material Green;

    void Start()
    {
        // Green = GreenMat.GetComponent<Renderer>().material;
        //playerColor = playerColor.GetComponent<Renderer>().material;
    }

    void OnCollisionEnter(Collision Col)
    {
        print("Collision");
        //if (Wall.GetComponent<Renderer>().material = Green)
        //{
        //    print("GREEEEEN");
        //}
        if (wallColor.GetComponent<Renderer>().material = playerColor.GetComponent<Renderer>().material)
        {
            print("GREEEEEN");
        }
        //switch ()
        //{
        //    case Green:
        //}
    }
}
