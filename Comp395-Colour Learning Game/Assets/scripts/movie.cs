using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movie : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
        movie.loop = true;
        movie.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
