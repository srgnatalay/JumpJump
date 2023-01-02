using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public AudioClip gameOverSound;

    private void Awake() => instance = this;

    public void Restart() => SceneManager.LoadScene(1);
    public void LoadMenu() => SceneManager.LoadScene(0);
    
    public void GameOver()
    {
        AudioSource.PlayClipAtPoint(gameOverSound, transform.position);
        UIManager.instance.GameOverSetup();
        PauseGameOnOff();
    }

    public void PauseGameOnOff() => Time.timeScale = Time.timeScale == 0 ? 1 : 0;
}
