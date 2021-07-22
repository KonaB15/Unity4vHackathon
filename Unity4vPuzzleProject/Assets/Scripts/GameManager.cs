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







    }
}
