using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{

    float range = 50f;


    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make raycast hit
        RaycastHit hit;


        //press f to open door
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            //shoot ray
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, range))
            {
                //if the ray hits something
                if (hit.transform.gameObject != null)

                {

                    //is it a door?
                    if (hit.transform.gameObject.CompareTag("Door"))
                    {
                        //if yes, then set it active for now
                        hit.transform.gameObject.SetActive(false);
                    }
                }

            
            
               
            }
        }

       
    }
}
