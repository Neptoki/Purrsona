using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    //*
    public Text coinText;
    int coinCount;

    private void OnEnable()
    {
        Coin.OnCoinCollected += IncrementCoinCount;
    }

    private void OnDisable()
    {
        Coin.OnCoinCollected -= IncrementCoinCount;
    }

    public void IncrementCoinCount()
    {
        coinCount++;
        coinText.text = $"Coins: {coinCount}";
    }
    //*
}
