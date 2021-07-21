using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BacktoMenuButton : MonoBehaviour
{
    //public GameObject puzzlemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        SendMessage("Puzzle1Completed");
        SceneManager.LoadScene("PlayerTest", LoadSceneMode.Single);
    }
}
