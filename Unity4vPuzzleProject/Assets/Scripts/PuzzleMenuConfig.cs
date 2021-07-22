using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PuzzleMenuConfig : MonoBehaviour
{

    public bool PuzzleTwoCompleted;
    public bool PuzzleThreeCompleted;

    public Button Puzzle1;
    public Button Puzzle2;
    public Button Puzzle3;

    public bool puzzle3shown = false;

    private Indestructable ind;


    public officeDoorScript officescript;
    public stairsDoorScript stairsscript;
    public masterbedroomDoorScript masterdoorscript;
    // Start is called before the first frame update
    void Start()
    {
        //hides puzzle 2 and 3 buttons
        Puzzle2.gameObject.SetActive(false);
        Puzzle3.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if last scene was puzzle1, if it is, unlock puzzle2
        if (Indestructable.instance.prevScene == 4)
        {
            Puzzle2.gameObject.SetActive(true);
            officescript.Puzzle1Complete();
        }
        if(puzzle3shown == true)
        {
            Puzzle3.gameObject.SetActive(true);
            stairsscript.Puzzle2Complete();
        }
    }
}
