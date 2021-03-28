using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseUI;
    [SerializeField] GameObject ShopPanel;
    //public static PauseMenu instance;
    //public bool gameOver = false;
    // Use this for initialization
    void Start()
    {
        pauseUI.SetActive(false);
    }
    // private void Awake()
    //{
    //    if (instance == null)
    //        instance = this;
    //}

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    pause = !pause;

        //}

        if (pause)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (pause == false)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }


    }
    public void mainmenu()
    {
        pause = !pause;
    }
    public void resume()
    {
        pause = false;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //[System.Obsolete]
    //public void LevelMenu()
    //{
    //    Application.LoadLevel("LevelMenu");
    //}
    public void quit()

    {
        Application.Quit();
      
    }
    public void shop()

    {
       

    }
    //public void OpenShop()
    //{
    //    ShopPanel.SetActive(true);
    //}

    //public void CloseShop()
    //{
    //    ShopPanel.SetActive(false);
    //}
    //[System.Obsolete]
    public void LevelMenu()
    {
        Application.LoadLevel("LevelMenu");
    }
    public void GameOver()
       
    {
        //SoundManager.instance.Death();
     //   SoundManager.ins
        //gameOver = true;
        //Time.timeScale = 0;
    }
         
}
