using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject BackgroundMusic;
    public void CatchaTrash()
    {
        SceneManager.LoadScene("Catch A Trash");
    }

    public void VirusRunner()
    {
        SceneManager.LoadScene("Virus Runner");
    }

    public void StopMusic()
    {
        BackgroundMusic.SetActive(false);
    }

    public void PlayMusic()
    {
        BackgroundMusic.SetActive(true);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Catch a Trash");
    }


}
