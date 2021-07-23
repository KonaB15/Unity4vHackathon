using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class FinalCutscene : MonoBehaviour
{

    public VideoPlayer finalvideo;
    // Start is called before the first frame update
    void Start()
    {
        finalvideo.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("StartMenuUI", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
