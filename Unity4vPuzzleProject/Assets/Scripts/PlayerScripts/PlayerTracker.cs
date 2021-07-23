using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTracker : MonoBehaviour
{
    public string CurrentRoom;

    public Text roomDisplay;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        roomDisplay.text = "Current Room: " + CurrentRoom;
    }
    void OnTriggerEnter(Collider other)
    {	
         //Checks which room is being collided with and saves the name
	if (other.gameObject.tag == "Room")
	{
	    CurrentRoom = (other.gameObject.name);
	    Debug.Log(CurrentRoom);
         
	}

    }
   
}
