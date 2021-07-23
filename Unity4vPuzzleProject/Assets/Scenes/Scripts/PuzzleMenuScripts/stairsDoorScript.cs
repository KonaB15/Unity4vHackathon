using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsDoorScript : MonoBehaviour
{

    public puzzle2Script puzzletwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzletwo.complete == true)
        {
            this.gameObject.SetActive(false);
        }
    }

  

}
