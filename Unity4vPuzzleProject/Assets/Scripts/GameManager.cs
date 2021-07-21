using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int gameLevel = 0;



    public int[] digits = { 0, 0, 0, 0, 0 };

    public int puzzle = 1;

    //downstairs
    public bool office = false;


    public bool stairs = false;

    public bool master = false;


    //scripts
    public puzzle1Script puzzle1;
    public puzzle2Script puzzle2;
    public puzzle3Script puzzle3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            digits[i] = (Random.Range(0, 10));
            Debug.Log(digits[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {

        if (puzzle1.complete == true)
        {
            puzzle = 2;
            office = true;
        }

        else if (puzzle2.complete == true)
        {
            puzzle = 3;
            stairs = true;
        }

        else if (puzzle3.complete == true)
        {
            puzzle = 4;
            master = true;
        }






    }
}
