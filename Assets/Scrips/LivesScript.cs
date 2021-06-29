using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour
{
    private int lifeCounter;
    [SerializeField] Text livesText;

    void Start()
    {
        lifeCounter = PlayerPrefs.GetInt("Lives");
    }

    void Update()
    {
        livesText.text = lifeCounter.ToString("Lives: 0");
        PlayerPrefs.SetInt("Lives", lifeCounter);

        if (lifeCounter <= 0)
        {
            StartCoroutine(waitForTime());
        }
    }

    public void TakeLife()
    {
        lifeCounter--;
    }
    
    public IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(3f);
        if(PlayerPrefs.GetInt("HighScore") > PlayerPrefs.GetInt("OldHS"))
        {
            SceneManager.LoadScene("NewHighScore");
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
