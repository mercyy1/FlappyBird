using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerScript : MonoBehaviour
{
    public int playerScore = 0;

    public GameObject gameOverScreen;

    public Text scoreText;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore+= scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }


    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            gameOver();
        }
    }

}
