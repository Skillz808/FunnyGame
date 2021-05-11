using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void QuitTheGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void OpenLink()
        {
            Application.OpenURL("https://github.com/Skillz808");
        }
    }

