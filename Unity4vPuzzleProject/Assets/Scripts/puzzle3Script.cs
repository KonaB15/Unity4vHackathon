using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzle3Script : MonoBehaviour
{
    public Text winScreen;
    public InputField input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       if (input.text == "your name" || input.text == "name" || input.text == "my name" || input.text == "Your name" || input.text == "Name" || input.text == "My name" || input.text == "Your Name" || input.text == "My Name")
        {
            winScreen.color = Color.green;
            winScreen.text = "Correct. So you've made it this far.";
        }
        else
        {
            winScreen.color = Color.red;
            winScreen.text = "Wrong";
        }

    }
}
