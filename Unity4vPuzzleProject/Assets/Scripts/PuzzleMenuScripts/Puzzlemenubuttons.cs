using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Puzzlemenubuttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void puzzleOne()
    {
        SceneManager.LoadScene("puzzle1", LoadSceneMode.Single);
    }
    public void puzzleTwo()
    {
        SceneManager.LoadScene("puzzle2", LoadSceneMode.Single);
    }
    public void puzzleThree()
    {
        SceneManager.LoadScene("puzzle3", LoadSceneMode.Single);
    }

    public void ExitDesktop()
    {
        SceneManager.LoadScene("PlayerTest", LoadSceneMode.Single);
    }
}
