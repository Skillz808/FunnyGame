using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime;
    //float startingTime = 5f;
    public GameObject lostText;
    public GameObject lostSound;
    public GameObject winText;
    public GameObject winSound;
    public GameObject infoText;
    public GameObject muteBGMusic;
    public GameObject alreadywon;
    public GameObject alreadylost;
    private LivesScript lifeSystem;
    public GameObject isInputEnabled;
    public int livesRemaning;
    public GameObject gameOverSound;
    public GameObject isSpeedUp;
    public GameObject winSoundSpeed;
    public GameObject speedUpText;
    public GameObject isNotSpeedUp;

    [SerializeField] Text countdownText;

    void Start()
    {
        lifeSystem = FindObjectOfType<LivesScript>();
        livesRemaning = PlayerPrefs.GetInt("Lives");
        currentTime = PlayerPrefs.GetFloat("currentTime");
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("Time: 0");

        if (alreadywon.activeInHierarchy)
        {
            StartCoroutine(winDelay());
        }

        if (currentTime <= 0)
        {
            if (alreadywon.activeInHierarchy)
            {
                currentTime = 100000000;
            }

            else
            {
                currentTime = 0;
                lostText.SetActive(true);
                muteBGMusic.SetActive(false);
                alreadylost.SetActive(true);
                StartCoroutine(waitForTime());
                isInputEnabled.SetActive(false);
                lifeSystem.TakeLife();
                infoText.SetActive(false);
                if (livesRemaning <= 1)
                {
                    gameOverSound.SetActive(true);
                }
                if (livesRemaning > 1)
                {
                    lostSound.SetActive(true);
                }
            }
        }

        if (alreadylost.activeInHierarchy)
        {
            currentTime = 100000000000;
        }
    }

    public IEnumerator waitForTime()
    {
        if (isSpeedUp.activeInHierarchy)
        {
            yield return new WaitForSeconds(6.156f);
            SceneManager.LoadScene(1);
            isSpeedUp.SetActive(false);
        }
        else
        {
            yield return new WaitForSeconds(4.178f);
            SceneManager.LoadScene(1);
        }
    }
    
    public IEnumerator winDelay()
    {
        yield return new WaitForSeconds(1f);
        if (isNotSpeedUp.activeInHierarchy)
        {
            winText.SetActive(true);
        }

        if (isSpeedUp.activeInHierarchy)
        {
            winSoundSpeed.SetActive(true);
            StartCoroutine(speedUpTextDelay());
            muteBGMusic.SetActive(false);
            StartCoroutine(waitForTime());
            alreadywon.SetActive(true);
            isInputEnabled.SetActive(false);
            isNotSpeedUp.SetActive(false);
            infoText.SetActive(false);
            currentTime = 1000000;
        }
        else
        {
            winSound.SetActive(true);
            muteBGMusic.SetActive(false);
            StartCoroutine(waitForTime());
            alreadywon.SetActive(true);
            isInputEnabled.SetActive(false);
            infoText.SetActive(false);
            currentTime = 1000000;
        }

    }

    public IEnumerator speedUpTextDelay()
    {
        yield return new WaitForSeconds(2.121f);
        winText.SetActive(false);
        speedUpText.SetActive(true);
    }
}
