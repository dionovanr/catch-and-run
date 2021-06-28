using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int skor;
    private int health = 3;

    public Text skorUI, HealthUI, skorAkhir;
    public GameObject GameOverUI, gameOverSound, backgroundMusic;
    

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
      

    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suntik")
        {
            skor++;
            skorUI.text = skor.ToString();
            SoudManager.PlaySound("collect");
        }

        if (collision.gameObject.tag == "Manusia")
        {
            health--;
            HealthUI.text = "Health: " + health.ToString();
            SoudManager.PlaySound("zonk");
            gameOverSound.SetActive(true);
        }

        if (collision.gameObject.tag == "Virus" || health == 0 || collision.gameObject.tag == "BatasBawah")
        {
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
            skorAkhir.text = skor.ToString();
            gameOverSound.SetActive(true);
            backgroundMusic.SetActive(false);
        }
    }
}
