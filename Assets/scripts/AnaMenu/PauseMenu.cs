using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public bool oyundurdumu; 
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resumes();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resumes()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       

    }
    public void ContinueResume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void LoadMenu()
    {
       SceneManager.LoadScene("MainMenu");
        
    }
    

    public void oyundur()
    {
        if (GameIsPaused)
        {
            Resumes();
        }
        else
        {
            Pause();
        }
    }
   
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Yönetici.scoresayýsý = 0;
        GameIsPaused = false;
        Time.timeScale = 1f;


    }
}
