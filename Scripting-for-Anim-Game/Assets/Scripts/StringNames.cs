using UnityEngine;
using System.Collections;
using System;

public class StringNames : MonoBehaviour {

    public string firstName;
    public string lastName;
    private string userName;

    void OnMouseUp ()
    {
        print( UserInfo () );
        print(userName + " is your User Name.");
    }

    string UserInfo()
    {
        userName = firstName + lastName+117;
        return firstName + " " + lastName + ", are you ready to rumble?";
    }

}
