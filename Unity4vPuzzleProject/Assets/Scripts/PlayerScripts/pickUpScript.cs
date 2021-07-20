using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{

    float range = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //hold 'f' to pick up object in crosshair
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                //what happens to object that is picked up/selected
                
                
               
            }
        }

        //let go of 'f' to drop
        if (Input.GetKeyUp(KeyCode.F))
        {
            //dropping object
        }
    }
}
