using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourStuff : MonoBehaviour {

    public Material[] materials;
    public float changeInterval = 0.33F;
    public Renderer rend;

    public GameObject[] badCars;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            //orange
            if (rend.material.color == Color.yellow)
            {
                rend.material.color = new Color32(255, 120, 0, 1);
            }
            //purple
            else if(rend.material.color == Color.blue)
            {
                rend.material.color = new Color32(128, 0, 128, 1);
            }

            else
            {
                rend.material.SetColor("_Color", Color.red);
            }
            

        }

        if (other.CompareTag("Blue"))
        {
            //green
            if (rend.material.color == Color.yellow)
            {
                rend.material.SetColor("_Color", Color.green);
            }
            //purple
            else if(rend.material.color == Color.red)
            {
                rend.material.color = new Color32(128, 0, 128, 1);
            }
            else
            {
                rend.material.SetColor("_Color", Color.blue);
            }


        }

        if (other.CompareTag("Yellow"))
        {
            //green
            if(rend.material.color == Color.blue)
            {
                rend.material.SetColor("_Color", Color.green);
            }
            //orange
            else if (rend.material.color == Color.red)
            {
                rend.material.color = new Color32(255, 120, 0, 1);
            }
            else
            {
                rend.material.SetColor("_Color", Color.yellow);
            }
            

        }

        if (other.CompareTag("White"))
        {

            rend.material.SetColor("_Color", Color.white);

        }

    }
}
