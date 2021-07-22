using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BacktoMenuButton : MonoBehaviour
{
    public GameObject indestructable;
    public int sceneNumber;
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
        SceneManager.LoadScene("PlayerTest", LoadSceneMode.Single);
        DontDestroyOnLoad(indestructable);
    }

    public void LoadScene(int sceneNumber)
    {
        Indestructable.instance.prevScene = Application.loadedLevel;

        Application.LoadLevel(sceneNumber);
    }
}
