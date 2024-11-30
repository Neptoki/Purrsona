using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel;
    public int coinCount;
    public Text coinText;

    public void Setup(int coins)
    {
        gameObject.SetActive(true);
        coinText.text = coins.ToString() + "mew-nies collected: ";
    }

    public void Setup(bool isGameOver)
    {
        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            gameOverPanel.SetActive(false);
        }
        
    }
    void Update()
    {
        coinText.text = "mew-nies collected: " + coinCount.ToString();
    }
}