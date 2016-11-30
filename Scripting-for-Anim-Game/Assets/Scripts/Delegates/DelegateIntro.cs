using UnityEngine;
using System;

public class DelegateIntro : MonoBehaviour {

    public static Action MyEvent;
    public static Action<string> EventWithArgs;
    public static Func<string> EventString;

    public static Func<string, string> EventReturnArgs;

	// Use this for initialization
	void Start ()
    {
        string data = EventReturnArgs("CATS!");

        print(data);

        print(EventString());

        EventWithArgs("Hello World");

        if (MyEvent != null)
            MyEvent();
	}
}
