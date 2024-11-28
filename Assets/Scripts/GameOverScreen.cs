using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text coinsText;
    public GameObject gameOverPanel;

    public void Setup (int coins)
    {
        gameObject.SetActive(true);
        coinsText.text = coins.ToString() + "MEW-NIES!";
    }

    public void Setup(bool isGameOver)
    {
        if (isGameOver)
        {
            gameOverPanel.SetActive(true); 
        }
        else
        {
            gameOverPanel.SetActive(false);
        }
    }
}
