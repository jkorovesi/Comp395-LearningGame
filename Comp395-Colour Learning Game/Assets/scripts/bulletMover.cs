using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMover : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 15f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
