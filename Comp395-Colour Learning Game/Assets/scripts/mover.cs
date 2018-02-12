using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    //public float speed;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * Random.Range(-15, -5);
        Debug.Log(GetComponent<Rigidbody>().velocity);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
