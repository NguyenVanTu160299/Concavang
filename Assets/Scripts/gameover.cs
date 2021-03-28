using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    public GameObject GameOver;
    //public bool pause = false;
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {
        //if (pause)
        //{
        //    GameOver.SetActive(true);
        //    Time.timeScale = 0;
        //}
        //else
        //{
        //    GameOver.SetActive(false);
        //    Time.timeScale = 1;
        //}
    }
}
