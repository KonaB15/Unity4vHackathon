using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class OpeningCutsceneSwitcher : MonoBehaviour
{

    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("OpeningCutscene2", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
