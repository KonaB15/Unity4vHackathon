using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puzzle2Script : MonoBehaviour
{
    public Button BacktoMenu;
    public InputField input;
    public Text winScreen;
    //public GameManager manageScript;
    public bool complete = false;

    public Canvas crosshair;
    public Canvas puzzlemenu;
    public Canvas puzzle2;
    public Canvas puzzle3;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("PuzzleMenu").GetComponent<PuzzleMenuConfig>().puzzle3shown = false;
        BacktoMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (input.text == "You got it" || input.text == "you got it" || input.text == "YOU GOT IT" || input.text == "You Got It")

        {
            winScreen.color = Color.green;
            winScreen.text = "Looks like you’ve finished 2 puzzles now! You're a bit better than I thought, unfortunately. A bit of the second floor has opened up. By the way, Don’t forget this hint that I’m about to give you, “Purple”! -Kle2";
            BacktoMenu.gameObject.SetActive(true);
            complete = true;
        }
        else if (input.text != null && input.text != "")
        {
            winScreen.color = Color.red;
            winScreen.text = "Wrong";
            BacktoMenu.gameObject.SetActive(false);
        }
       
    }

    public void BackToHousePuzzleTwo()
    {
        //go back to house and show puzzle 3 button
        GameObject.Find("PuzzleMenu").GetComponent<PuzzleMenuConfig>().puzzle3shown = true;
        crosshair.gameObject.SetActive(true);
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
    }
}
