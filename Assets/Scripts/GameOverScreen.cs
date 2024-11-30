using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text coinsText;
    public GameObject gameOverPanel;
    public int coinCount;
    public Text coinText;
    public Text collectedText;

    public void Setup(int coins)
    {
        gameObject.SetActive(true);
        coinsText.text = coins.ToString() + "meow-nies collected: ";
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
        collectedText.text = "meow-nies collected: " + coinCount.ToString();
    }
}
