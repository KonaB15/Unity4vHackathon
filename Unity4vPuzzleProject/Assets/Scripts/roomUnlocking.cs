using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomUnlocking : MonoBehaviour
{
    public GameManager manageScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.CompareTag("office"))
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

        if (transform.gameObject.CompareTag("gym"))
        {
            if (manageScript.gym == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("garage"))
        {
            if (manageScript.garage == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("downBathroom"))
        {
            if (manageScript.downBathroom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("kitchen"))
        {
            if (manageScript.kitchen == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("livingRoom"))
        {
            if (manageScript.livingRoom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("entrance"))
        {
            if (manageScript.entrance == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        //upstairs

        if (transform.gameObject.CompareTag("masterBedroom"))
        {
            if (manageScript.masterBedroom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("guestBedroom"))
        {
            if (manageScript.guestBedroom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("masterBathroom"))
        {
            if (manageScript.masterBathroom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("guestBathroom"))
        {
            if (manageScript.guestBathroom == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

        if (transform.gameObject.CompareTag("storageCloset"))
        {
            if (manageScript.storageCloset == true)
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
