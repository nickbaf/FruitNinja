using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreT;





    public void scoreAdd(int points)
    {
        score += points;
        scoreT.text = score.ToString();
    }



    public void onBombHit()
    {
        Time.timeScale = 0;
    }
}
