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
    public Text ScoreText;

    public UnityEvent onGameOver;

    public GameObject gameOverMenu;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
       gameOverMenu.SetActive(false); //gameOverMenu is off at start
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore(int amount) //need a collision with coin to trigger the score increase 
    {
        score += amount;
        Debug.Log("Score: " + score);
        //new score = old score + amount
        ScoreText.text = "Score: " + score.ToString();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        finalScoreText.text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        onGameOver.Invoke(); //trigger
    }

    public void CoinMessage()
    {
        Debug.Log("player collided with coin");
    }

    public void EnemyMessage()
    {
        Debug.Log("player collided with enemy");
    }

    public void BulletMessage()
    {
        Debug.Log("bullet has hit enemy");
    }

    public void SpaceshipMessage()
    {
        Debug.Log("player collided with spaceship");
    }

    public void PowerupMessage()
    {
        Debug.Log("player collided with powerup - can now double jump");
    }
}

