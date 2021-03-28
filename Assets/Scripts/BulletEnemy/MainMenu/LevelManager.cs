using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    int LevelsUnlocked;
    public Button[] buttons;
    void Start()
    {
        LevelsUnlocked = PlayerPrefs.GetInt("LlevelIsUnlocked", 1);
        for(int i =0; i<buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
        //for (int i = 0; i < LevelsUnlocked; i++)
        //{
        //    buttons[i].interactable = true;
        //}
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
   void Update()
    {
        
    }

    //public void PlayGame()
    //{
    //	Application.LoadLevel("GamePlay");
    //}

    //public void BackToMenu()
    //{
    //	Application.LoadLevel("MainMenu");
    //}
    //[System.Obsolete]
  //  [System.Obsolete]
    public void PlayGame(int sceneANumber)
    {
    sceneANumber = 0;
        SceneManager.LoadScene(sceneANumber);
       // Application.LoadLevel("PlayGame");
    }


}
