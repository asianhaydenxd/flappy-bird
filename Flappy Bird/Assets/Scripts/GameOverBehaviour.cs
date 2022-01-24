using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBehaviour : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject scoreText;

    void Start()
    {
        gameOverMenu.SetActive(false);
        scoreText.SetActive(true);
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        scoreText.SetActive(false);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
