using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int[] digits = {0, 0, 0, 0, 0};

    public int puzzle = 1;

    //downstairs
    public bool office = false;
    public bool gym = false;
    public bool garage = false;
    public bool downBathroom = false;
    public bool kitchen = false;
    public bool livingRoom = false;
    public bool entrance = false;


    //upstairs
    public bool masterBedroom = false;
    public bool guestBedroom = false;
    public bool masterBathroom = false;
    public bool guestBathroom = false;
    public bool storageCloset = false;


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
        }

       else if (puzzle2.complete == true)
        {
            puzzle = 3;
        }

        else if (puzzle3.complete == true)
        {
            puzzle = 4;
        }


        



    }
}
