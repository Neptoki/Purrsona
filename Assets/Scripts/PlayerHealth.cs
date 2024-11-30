using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 9f;
    public float health;
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
    public GameObject Heart9;
    public GameObject Heart10;
    public GameObject Heart11;
    public GameObject Heart12;
    public GameObject Heart13;
    public GameObject Heart14;
    public GameObject Heart15;
    public GameObject Heart16;
    public GameObject Heart17;
    [SerializeField] private SimpleFlash flashEffect;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        flashEffect.Flash();
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
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
                    Heart9.gameObject.SetActive(false);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 10:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(false);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 11:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(false);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 12:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(false);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 13:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(false);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 14:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(true);
                    Heart14.gameObject.SetActive(false);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 15:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(true);
                    Heart14.gameObject.SetActive(true);
                    Heart15.gameObject.SetActive(false);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 16:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(true);
                    Heart14.gameObject.SetActive(true);
                    Heart15.gameObject.SetActive(true);
                    Heart16.gameObject.SetActive(false);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 17:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(true);
                    Heart14.gameObject.SetActive(true);
                    Heart15.gameObject.SetActive(true);
                    Heart16.gameObject.SetActive(true);
                    Heart17.gameObject.SetActive(false);
                    break;
                }
            case 18:
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
                    Heart9.gameObject.SetActive(true);
                    Heart10.gameObject.SetActive(true);
                    Heart11.gameObject.SetActive(true);
                    Heart12.gameObject.SetActive(true);
                    Heart13.gameObject.SetActive(true);
                    Heart14.gameObject.SetActive(true);
                    Heart15.gameObject.SetActive(true);
                    Heart16.gameObject.SetActive(true);
                    Heart17.gameObject.SetActive(true);
                    break;
                }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            maxHealth *= 2;
            health += 9f;
        }
    }
}
