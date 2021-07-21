using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Puzzlemenubuttons : MonoBehaviour
{
    public Canvas crosshair;
    public Canvas puzzlemenu;
    public Canvas puzzle2;
    public Canvas puzzle3;

    public 
    // Start is called before the first frame update
    void Start()
    {
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(true);
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
        puzzle2.gameObject.SetActive(true);
        puzzle3.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(false);
    }
    public void puzzleThree()
    {
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(true);
        puzzlemenu.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(false);
    }

    public void ExitDesktop()
    {
        SceneManager.LoadScene("PlayerTest", LoadSceneMode.Single);
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(true);
    }
}
