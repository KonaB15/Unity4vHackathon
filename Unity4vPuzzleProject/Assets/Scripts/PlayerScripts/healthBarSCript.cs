using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBarSCript : MonoBehaviour
{


    public Text healthText;
    public int health = 100;

    public int frames = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
        frames++;

        if (frames % 4000 == 0)
        {
            health--;
        }

        healthText.text = health.ToString();
    }
}
