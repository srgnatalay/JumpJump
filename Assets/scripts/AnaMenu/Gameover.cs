using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    AudioSource audiosource;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Y�netici.scoresay�s� = 0;

    }
    public void LoadMenu()
    {

        SceneManager.LoadScene("MainMenu");
        Y�netici.scoresay�s� = 0;
        
    }
    public void QuitGame()
    {
        Debug.Log("OYUNDAN �IKTIN...");
        Application.Quit();
        Y�netici.scoresay�s� = 0;
    }
}
