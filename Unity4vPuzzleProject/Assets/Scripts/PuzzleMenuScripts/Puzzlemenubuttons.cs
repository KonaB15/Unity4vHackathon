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
        puzzle2.gameObject.SetActive(true);
        puzzlemenu.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(false);
    }
    public void puzzleThree()
    {
        puzzle2.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(true);
        crosshair.gameObject.SetActive(false);
    }

    public void ExitDesktop()
    {
        puzzle2.gameObject.SetActive(false);
        puzzlemenu.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
        crosshair.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
