using UnityEngine;
using System.Collections;

public class PassThrough : MonoBehaviour {
   
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
        {
            Physics.IgnoreLayerCollision(8, 13, true);
            print("go through");
            StartCoroutine(TurnLayerBackOn());
        }

        else if (col.gameObject.GetComponent<Renderer>().material.color != gameObject.GetComponent<Renderer>().material.color)
        {
            Physics.IgnoreLayerCollision(8, 13, false);
            print("no through");
        }
    }

    public IEnumerator TurnLayerBackOn ()
    {
        yield return new WaitForSeconds(1.5f);
        print("Cannot pass through now");
        Physics.IgnoreLayerCollision(8, 13, false);        
    }
}

