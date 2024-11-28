using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Coin : MonoBehaviour, UICollectible
{
    public static event Action OnCoinCollected;
    public void Collect()
    {
        Debug.Log("collected")
        Destroy(gameObject);
        OnCoinCollected?.Invoke();
    }
}
