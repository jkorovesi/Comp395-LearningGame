using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingPong : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3( -28.8f + Mathf.PingPong(Time.time * 30, -0.8f), transform.position.y, 9.5f + Mathf.PingPong(Time.time * 30, -0.8f));
    }
}
