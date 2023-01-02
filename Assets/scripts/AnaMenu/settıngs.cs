using UnityEngine;


public class settıngs : MonoBehaviour
{
    [SerializeField] AudioSource music;
    public static bool SetingsIsPaused = false;
    public GameObject SettingsMenuUI;
   

     void Start()
    {
     AudioListener.pause = false;
    }

  
    public void Onmucis()
    {

        music.Play();
        AudioListener.pause = false;

    }
    public void OffMusic()
    {
        music.Stop();
        AudioListener.pause = true;

    }
    void kapalı()
    {
        SettingsMenuUI.SetActive(false);
        SetingsIsPaused = false;
    }
    void settings()
    {
        SettingsMenuUI.SetActive(true);
        SetingsIsPaused = true;
    }

    public void kapat()
    {
        if (SetingsIsPaused)
        {
            kapalı();
        }
        else
        {
            settings();
        }
    }

  
   
}
