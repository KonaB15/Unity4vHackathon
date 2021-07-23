using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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

        if (frames % 5000 == 0)
        {
            health -= 10;
            if(health <= 0)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }

        healthText.text = "Health: " + health.ToString();
    }
}
