using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 9;
    public int health;
    public GameOverScreen GameOverScreen;
    public GameObject Heart;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;
    public GameObject Heart6;
    public GameObject Heart7;
    public GameObject Heart8;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            health = 0;
            GameOver();
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        if (GameOverScreen != null)
        {
            GameOverScreen.Setup(true);
        }
    }

    void Update()
    {
        switch (health) // health hearts UI
        {
            case 0:
                {
                    Heart.gameObject.SetActive(false);
                    Heart1.gameObject.SetActive(false);
                    Heart2.gameObject.SetActive(false);
                    Heart3.gameObject.SetActive(false);
                    Heart4.gameObject.SetActive(false);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(false);
                    Heart2.gameObject.SetActive(false);
                    Heart3.gameObject.SetActive(false);
                    Heart4.gameObject.SetActive(false);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(false);
                    Heart3.gameObject.SetActive(false);
                    Heart4.gameObject.SetActive(false);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(false);
                    Heart4.gameObject.SetActive(false);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 4:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(false);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 5:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(true);
                    Heart5.gameObject.SetActive(false);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 6:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(true);
                    Heart5.gameObject.SetActive(true);
                    Heart6.gameObject.SetActive(false);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 7:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(true);
                    Heart5.gameObject.SetActive(true);
                    Heart6.gameObject.SetActive(true);
                    Heart7.gameObject.SetActive(false);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 8:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(true);
                    Heart5.gameObject.SetActive(true);
                    Heart6.gameObject.SetActive(true);
                    Heart7.gameObject.SetActive(true);
                    Heart8.gameObject.SetActive(false);
                    break;
                }
            case 9:
                {
                    Heart.gameObject.SetActive(true);
                    Heart1.gameObject.SetActive(true);
                    Heart2.gameObject.SetActive(true);
                    Heart3.gameObject.SetActive(true);
                    Heart4.gameObject.SetActive(true);
                    Heart5.gameObject.SetActive(true);
                    Heart6.gameObject.SetActive(true);
                    Heart7.gameObject.SetActive(true);
                    Heart8.gameObject.SetActive(true);
                    break;
                }
        }
    }
}
