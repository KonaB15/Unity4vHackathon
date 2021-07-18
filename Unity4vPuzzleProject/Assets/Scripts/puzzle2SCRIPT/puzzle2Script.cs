using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puzzle2Script : MonoBehaviour
{

    public InputField input;
    public Text winScreen;
    public GameManager manageScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.text == "You got it" || input.text == "you got it" || input.text == "YOU GOT IT" || input.text == "You Got It")
        {
            winScreen.text = "YOU PASSED! first digit: " + manageScript.digits[0];
        }
    }
}
