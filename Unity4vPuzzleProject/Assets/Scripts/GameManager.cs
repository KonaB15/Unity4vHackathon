using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int[] digits = {0, 0, 0, 0, 0};


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
