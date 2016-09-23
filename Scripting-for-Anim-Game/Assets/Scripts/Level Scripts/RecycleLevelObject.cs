using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevelObject : MonoBehaviour {


    private Vector3 newLocation;
    public List<Recycler> recyblableList;
    private int i = 0;

    void Start ()
    {
        recyblableList = new List<Recycler>();
        Recycler.recycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        recyblableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, recyblableList.Count - 1);
        newLocation.x = StaticVars.nextSectionPos;
        recyblableList[i].cube.position = newLocation;
        StaticVars.nextSectionPos += StaticVars.distance;
        if (recyblableList.Count > 0)
            recyblableList.RemoveAt(i);
    }

}
