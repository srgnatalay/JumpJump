using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScoreText;
    private int score;
    
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    private void Awake() => instance = this;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void PausePanelOnOff()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
        GameManager.instance.PauseGameOnOff();
    }

    public void GameOverSetup()
    {
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = score.ToString();
    }
}
