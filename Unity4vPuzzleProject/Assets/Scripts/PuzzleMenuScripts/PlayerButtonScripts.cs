using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerButtonScripts : MonoBehaviour
{
    public Canvas crosshair;
    public Canvas puzzlemenu;
    public Canvas puzzle2;
    public Canvas puzzle3;
    // Start is called before the first frame update
    void Start()
    {
        crosshair.gameObject.SetActive(true);
        puzzlemenu.gameObject.SetActive(false);
        puzzle2.gameObject.SetActive(false);
        puzzle3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            Desktop();
        }
    }

    public void Desktop()
    {
        puzzlemenu.gameObject.SetActive(true);
        crosshair.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
}