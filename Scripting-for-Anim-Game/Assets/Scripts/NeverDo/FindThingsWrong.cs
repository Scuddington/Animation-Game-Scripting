using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindThingsWrong : MonoBehaviour {

    public List<GameObject> level;

    // Use this for initialization
    void Start()
    {
        GameObject temp = GameObject.Find("Plane");
        level.Add(temp);
    }
}
