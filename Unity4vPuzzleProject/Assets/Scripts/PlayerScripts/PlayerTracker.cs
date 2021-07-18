using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public string CurrentRoom;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    void OnCollisionEnter(Collision collision)
    {	
         //Checks which room is being collided with and saves the name
	if (collision.gameObject.tag == "Floor")
	{
	    CurrentRoom = (collision.gameObject.name);
	    Debug.Log(CurrentRoom);
	}
    }
   
}
