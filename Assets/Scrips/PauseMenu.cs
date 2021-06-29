using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;

    public GameObject HideWinText;
    public GameObject HideLoseText;
    public GameObject hideInfoText;
    public GameObject hideSpeedText;
    public GameObject mobilePauseButton;
    public GameObject isInputEnabled;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isPaused = !isPaused;
        }

        if (mobilePauseButton.activeInHierarchy)
        {
            isPaused = true;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        if(!isPaused)
        {
            DeactivateMenu();
        }
    }

    public void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;
        HideWinText.SetActive(false);
        HideLoseText.SetActive(false);
        hideInfoText.SetActive(false);
        isInputEnabled.SetActive(false);
        hideSpeedText.SetActive(false);
    }

    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
        isPaused = false;
        isInputEnabled.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
