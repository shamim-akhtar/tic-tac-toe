using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGGE.Patterns;
using UnityEngine.SceneManagement;

public class GameApp : Singleton<GameApp>
{
    public AmbientSound mAmbientSound;
    public AudioClip[] mAudioClips;
    void Start()
    {
        SceneManager.LoadScene("_splash_screen");
    }

    void Update()
    {

    }    // called first
    void OnEnable()
    {
        //Debug.Log("OnEnable called");
        //SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called when the game terminates
    void OnDisable()
    {
        //Debug.Log("OnDisable");
        //SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
