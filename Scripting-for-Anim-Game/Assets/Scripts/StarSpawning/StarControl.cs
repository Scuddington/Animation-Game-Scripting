using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {

    public int forceTime = 10;
    public float endTime = 3;
    private bool canAddForce = true;
    public float forceRange;
    private int torqueRange;
    public float forceDuration;
    private Vector3 forceVector;
    private Vector3 torqueVector;
    private Rigidbody rigid;
    private float force;

    private Animator anims;

	// Use this for initialization
	void Start ()
    {
        anims = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
	}

    void OnCollisionEnter()
    {
        canAddForce = false;
        anims.SetBool("Destroy", false);
    }
	
    IEnumerator RunRandomForce()
    {
        while (forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = Random.Range(-forceRange, forceRange);
            torqueVector.z = Random.Range(-torqueRange, torqueRange);
            rigid.AddTorque(torqueVector);
            rigid.AddForce(forceVector);
            forceTime--;
        }
        
    }

    public void Deactivate()
    {
        anims.SetBool("Destroy", false);
        gameObject.SetActive(false);
    }
}
