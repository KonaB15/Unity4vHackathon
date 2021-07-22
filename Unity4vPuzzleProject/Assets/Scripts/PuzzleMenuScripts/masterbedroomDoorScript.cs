using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterbedroomDoorScript : MonoBehaviour
{

    public puzzle3Script puzzlethree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzlethree.complete == true)
        {
            this.gameObject.SetActive(false);
        }
    }

    
}
