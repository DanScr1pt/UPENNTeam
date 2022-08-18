using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public Text finalScoreText;
    public Text finalHighScoreText;
    public Text youWinText;
    public Text scoreText;
    
    private int score = 0;
    public GameObject gameOverMenu;
    public UnityEvent onGameOver;

    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        onGameOver.Invoke();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        finalScoreText.text = "Score: " + score.ToString();
    }
}