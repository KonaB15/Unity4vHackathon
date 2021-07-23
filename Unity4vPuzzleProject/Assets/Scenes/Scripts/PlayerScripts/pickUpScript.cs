using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{

    float range = 50f;

    public healthBarSCript healthbar;

    public AudioSource sodaCanSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray newRay = new Ray(transform.position,transform.forward);

        //hold 'f' to pick up object in crosshair
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(newRay, out hit, range))
            {
                if (hit.transform.gameObject != null)
                {
                    if (hit.transform.gameObject.CompareTag("can"))
                    {

                        sodaCanSound.Play();
                        hit.transform.gameObject.SetActive(false);
                        healthbar.health = 100;
                       
                    }
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
