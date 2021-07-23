using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class TwoCutsceneSwitcher : MonoBehaviour
{

    public VideoPlayer videotwo;
    // Start is called before the first frame update
    void Start()
    {
        videotwo.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("PlayerTest", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
