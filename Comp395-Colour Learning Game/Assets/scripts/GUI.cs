using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    public Button startButton;
    public Button difficulty;
    // Use this for initialization
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("main");
        }
    }
    
    public void OnClick()
    {
        Debug.Log("Clicked OnClick");
           // SceneManager.LoadScene("scene1");
    }

}
