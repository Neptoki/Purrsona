using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    public GameObject gameOverPanel;
    public Text collectedText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Mew-nies: " + coinCount.ToString();
    }

    public void Setup(bool isGameOver)
    {
        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
            collectedText.text = "meow-nies collected: " + coinCount.ToString();
        }
        else
        {
            gameOverPanel.SetActive(false);
        }
    }
}
