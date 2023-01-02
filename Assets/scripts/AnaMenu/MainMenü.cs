using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenü : MonoBehaviour
{
    public GameObject SettingsMenuUI;
    public void playGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        Yönetici.scoresayısı = 0;
        
    }
    public void Settıngs()
    {

        SettingsMenuUI.SetActive(true);

    }
    public void QuitGame()
    {
        Debug.Log("OYUNDAN ÇIKTIN...");
        Application.Quit();
        Yönetici.scoresayısı = 0;
    }

}
