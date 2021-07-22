using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzle3Script : MonoBehaviour
{
    public Text winScreen;
    public InputField input;
    public bool complete = false;

    public Button BacktoMenuThree;

    public Canvas crosshair;
    public Canvas puzzlemenu;
    public Canvas puzzle2;
    public Canvas puzzle3;
    // Start is called before the first frame update
    void Start()
    {
        BacktoMenuThree.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
       if (input.text == "your name" || input.text == "name" || input.text == "my name" || input.text == "Your name" || input.text == "Name" || input.text == "My name" || input.text == "Your Name" || input.text == "My Name")
        {
            winScreen.color = Color.green;
            winScreen.text = "You were quick. I guess I’m a bit impressed. Your bedroom is open. There’s one last puzzle in your house. Look for a particular framed image.";
            BacktoMenuThree.gameObject.SetActive(true);
            complete = true;
           
        }
        else
        {
            winScreen.color = Color.red;
            winScreen.text = "Wrong";
            BacktoMenuThree.gameObject.SetActive(false);
        }

    }

    public void BackToHousePuzzle3()
    {
        crosshair.gameObject.SetActive(true);
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
    }
}
