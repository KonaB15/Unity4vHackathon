using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeDoorScript : MonoBehaviour
{




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Indestructable.instance.prevScene == 4)
        {
            this.gameObject.SetActive(false);

        }
    }




   
}
