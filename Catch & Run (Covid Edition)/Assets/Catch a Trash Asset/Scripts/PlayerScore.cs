using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text SkorText, SampahOrganikText, skorAkhir, skorWin;
    public int skor, sampahOrganik;
    public GameObject GameOverUI, BackgroundMusic, GameOverMusic, WinUI, WinMusic;
    public AudioSource SuaraCollect;

    private void Start()
    {
        SuaraCollect = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SampahPlastik")
        {
            skor++;
            SkorText.text = skor.ToString();
            SuaraCollect.Play();

            if (skor == 10)
            {
                WinUI.SetActive(true);
                WinMusic.SetActive(true);
                BackgroundMusic.SetActive(false);
                skorWin.text = skor.ToString();
                Time.timeScale = 0;
            }
        } 
        
        if (collision.gameObject.tag == "SampahOrganik")
        {
      
            SuaraCollect.Play();
            if (skor <= 0)
            {
                skor = 0;
                SkorText.text = skor.ToString();
            }
            else
            {
                skor--;
                SkorText.text = skor.ToString();
            }

            sampahOrganik++;
            SampahOrganikText.text = "Sampah Organik: " + sampahOrganik.ToString();

            if (sampahOrganik == 3)
            {
                GameOverUI.SetActive(true);
                skorAkhir.text = skor.ToString();
                Time.timeScale = 0;
                BackgroundMusic.SetActive(false);
                GameOverMusic.SetActive(true);
            }
            
        }
    }
}
