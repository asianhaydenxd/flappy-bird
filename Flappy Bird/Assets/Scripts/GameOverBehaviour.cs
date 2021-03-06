using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverBehaviour : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject scoreCanvas;

    public GameObject menuScore;
    public GameObject menuBest;

    public GameObject menuBestLabel;

    void Start()
    {
        gameOverMenu.SetActive(false);
        scoreCanvas.SetActive(true);
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        scoreCanvas.SetActive(false);

        if (ScoreUpdate.score > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", ScoreUpdate.score);

            menuBest.GetComponent<Text>().color = new Color(1, 0.89f, 0.32f, 1); // Yellow
            menuBestLabel.GetComponent<Text>().color = new Color(1, 0.89f, 0.32f, 1);
        }
        else
        {
            menuBest.GetComponent<Text>().color = new Color(1, 1, 1, 1); // White
            menuBestLabel.GetComponent<Text>().color = new Color(1, 1, 1, 1);
        }

        menuScore.GetComponent<Text>().text = ScoreUpdate.score.ToString();
        menuBest.GetComponent<Text>().text = PlayerPrefs.GetInt("highScore", 0).ToString();
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
