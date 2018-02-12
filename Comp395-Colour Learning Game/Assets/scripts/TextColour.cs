using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TextColour : MonoBehaviour {

    public Text colour;
    public Text score;
    private int points = 0;
    private string[] colours = new string[] { "Red", "Blue", "Yellow" };
    private string[] advColours = new string[] { "Red", "Blue", "Yellow", "Green", "Orange", "Purple" };
    public GameObject colourPlane;
    public GameObject player;
    private Renderer playerColour;
    private Renderer planeColour;
    private bool advMode = false;

	// Use this for initialization
	void Start () {
        planeColour = colourPlane.GetComponent<Renderer>();
        playerColour = player.GetComponent<Renderer>();
        colour.text = "Create " + colours[Random.Range(0, colours.Length)];
        if(colour.text == "Create Red")
        {
            planeColour.material.SetColor("_Color", Color.red);
        } else if(colour.text == "Create Blue")
        {
            planeColour.material.SetColor("_Color", Color.blue);
        }else if (colour.text == "Create Yellow")
        {
            planeColour.material.SetColor("_Color", Color.yellow);
        }
        score.text = "Score: 0";

    }
	
	// Update is called once per frame
	void Update () {

        changeColour();
        if(points >= 5)
        {
            advMode = true;
        }
        if(score.text == "Score: 20")
        {
            SceneManager.LoadScene("end");
        }

    }

    public void changeColour()
    {
        //red
        if (playerColour.material.color == Color.red && planeColour.material.color == Color.red)
        {
            if(advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }
            
            points++;
            score.text = "Score: " + points.ToString();
        }

        //blue
        if (playerColour.material.color == Color.blue && planeColour.material.color == Color.blue)
        {
            if (advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }

            points++;
            score.text = "Score: " + points.ToString();
        }

        //yellow
        if (playerColour.material.color == Color.yellow && planeColour.material.color == Color.yellow)
        {

            if (advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }

            points++;
            score.text = "Score: " + points.ToString();
        }

        //green
        if (playerColour.material.color == Color.green && planeColour.material.color == Color.green)
        {

            if (advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }

            points++;
            score.text = "Score: " + points.ToString();
        }

        //orange
        if (playerColour.material.color == new Color32(255, 120, 0, 1) && planeColour.material.color == new Color32(255, 120, 0, 1))
        {

            if (advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }

            points++;
            score.text = "Score: " + points.ToString();
        }

        //purple
        if (playerColour.material.color == new Color32(128, 0, 128, 1) && planeColour.material.color == new Color32(128, 0, 128, 1))
        {

            if (advMode == true)
            {
                advColorObj();
            }
            else
            {
                colorObj();
            }

            points++;
            score.text = "Score: " + points.ToString();
        }


    }

    public void colorObj()
    {
        colour.text = "Create " + colours[Random.Range(0, colours.Length)];
        if (colour.text == "Create Red")
        {
            planeColour.material.SetColor("_Color", Color.red);
        }
        else if (colour.text == "Create Blue")
        {
            planeColour.material.SetColor("_Color", Color.blue);
        }
        else if (colour.text == "Create Yellow")
        {
            planeColour.material.SetColor("_Color", Color.yellow);
        }
    }

    public void advColorObj()
    {
        colour.text = "Create " + advColours[Random.Range(0, advColours.Length)];
        if (colour.text == "Create Red")
        {
            planeColour.material.SetColor("_Color", Color.red);
        }
        else if (colour.text == "Create Blue")
        {
            planeColour.material.SetColor("_Color", Color.blue);
        }
        else if (colour.text == "Create Yellow")
        {
            planeColour.material.SetColor("_Color", Color.yellow);
        }
        else if (colour.text == "Create Green")
        {
            planeColour.material.SetColor("_Color", Color.green);
        }
        else if (colour.text == "Create Orange")
        {
            planeColour.material.color = new Color32(255, 120, 0, 1);
        }
        else if (colour.text == "Create Purple")
        {
            planeColour.material.color = new Color32(128, 0, 128, 1);
        }
    }
}
