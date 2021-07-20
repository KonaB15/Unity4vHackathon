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
        Ray newRay = new Ray(transform.position, Vector3.down);

        //hold 'f' to pick up object in crosshair
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Physics.Raycast(newRay, out hit, range))
            {
                if (hit.transform.gameObject != null)
                {
                    Debug.Log(hit.collider.tag);
                }

            
            
               
            }
        }

        //let go of 'f' to drop
        if (Input.GetKeyUp(KeyCode.F))
        {
            //dropping object
        }
    }
}
