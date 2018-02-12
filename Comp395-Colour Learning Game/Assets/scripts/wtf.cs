using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class wtf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.F))
        {
                SceneManager.LoadScene("wtf");   
        }
	}
}
