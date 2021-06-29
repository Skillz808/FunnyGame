using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    private int Lives = 3;
    private int Points = 0;
    private int firstLaunch;

    public void PlayCredits()
    {
        SceneManager.LoadScene(4);
    }

    public void ResetScores()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.SetInt("OldHS", 0);
    }

    public void PlayTheGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayKeyCardGame()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitTheGame()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Debug.Log("Quit Game");
            Application.ExternalEval("window.open(\"https://skillzdevelopment.xyz/\",\"_blank\")");
        }
        else
        {
            Application.OpenURL("https://skillzdevelopment.xyz/");
        }
    }

    public void OpenLink()
        {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"https://www.github.com/skillz808/\",\"_blank\")");
        }
        else
        {
            Application.OpenURL("https://www.github.com/skillz808");
        }
        }

    public void OpenBugNotes()
        {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.ExternalEval("window.open(\"https://skillzdevelopment.xyz/files/amogusbugs.txt\",\"_blank\")");
        }
        else
        {
            Application.OpenURL("https://skillzdevelopment.xyz/files/amogusbugs.txt");
        }
        }
        
    void Start()
    {
        PlayerPrefs.SetInt("Lives", Lives);
        PlayerPrefs.SetInt("Points", Points);
        firstLaunch = PlayerPrefs.GetInt("firstLaunch");
        PlayerPrefs.SetFloat("currentTime", 5f);
        if (firstLaunch == 0)
        {
            PlayerPrefs.SetFloat("volume", 0.5f);
            PlayerPrefs.SetInt("firstLaunch", 1);
        }
        Time.timeScale = 1;
        AudioListener.pause = false;
        PlayerPrefs.SetInt("OldHS", PlayerPrefs.GetInt("HighScore"));
    }
 }


