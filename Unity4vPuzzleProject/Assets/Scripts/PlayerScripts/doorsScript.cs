using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsScript : MonoBehaviour
{
    public GameManager manageScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.CompareTag("officeDoor"))
        {
            if (manageScript.office == true)
            {
                transform.gameObject.SetActive(false);
            }

            else
            {
                transform.gameObject.SetActive(true);
            }
        }


        if (transform.gameObject.CompareTag("stairsDoor"))
        {
            if (manageScript.stairs == true)
            {
                transform.gameObject.SetActive(false);
            }

            else
            {
                transform.gameObject.SetActive(true);
            }
        }


        if (transform.gameObject.CompareTag("masterDoor"))
        {
            if (manageScript.master == true)
            {
                transform.gameObject.SetActive(false);
            }

            else
            {
                transform.gameObject.SetActive(true);
            }
        }

    }
}
