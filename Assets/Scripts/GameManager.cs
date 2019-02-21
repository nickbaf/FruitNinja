using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Score Elements")]
    public int score;
    public int highScore;
    public Text scoreT;
    public Text highScoreT;

    [Header("GameOver")]
    public GameObject gameOverPanel;
    public Text gameOverScore;




    private void Awake()
    {
        gameOverPanel.SetActive(false);
        highScore = PlayerPrefs.GetInt("high");
        highScoreT.text = "BEST SCORE: " + highScore.ToString();
    }


    public void scoreAdd(int points)
    {
        score += points;
        scoreT.text = score.ToString();
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("high", highScore);
            highScoreT.text = "BEST SCORE: " + score.ToString();
        }
    }



    public void OnBombHit()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        gameOverScore.text = "Total Score:  " + score.ToString();
    }


    public void Restart()
    {
        Time.timeScale = 1;
        score = 0;
        scoreT.text = "0";
        gameOverPanel.SetActive(false);
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("interactible")) //lol
        {
            Destroy(g);
        }
            
    }
}
