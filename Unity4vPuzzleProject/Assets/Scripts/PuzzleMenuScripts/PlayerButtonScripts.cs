using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerButtonScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        SceneManager.LoadScene("PuzzleMenuL1", LoadSceneMode.Single);
        //Cursor.lockState = CursorLockMode.None;
    }
}
