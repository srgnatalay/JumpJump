using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public void GameplayScene() => SceneManager.LoadScene(1);
    public void QuitGame() => Application.Quit();
}
