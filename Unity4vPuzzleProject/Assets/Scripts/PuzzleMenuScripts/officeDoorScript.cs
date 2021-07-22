using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeDoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Puzzle1Complete()
    {
        Debug.Log("done");
         transform.gameObject.SetActive(false);
      
    }
}
