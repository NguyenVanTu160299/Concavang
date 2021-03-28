using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamewin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //[System.Obsolete]
    public void LevelMenu(int sceneANumber)
    {
        sceneANumber = 1;
        SceneManager.LoadScene(sceneANumber);
        // Application.LoadLevel("PlayGame");
    }
}