using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LightGameMain : MonoBehaviour
{
    static public LightGameMain Instance;

    public int SwitchCount;
    public GameObject winText;
    public GameObject winSound;
    public GameObject muteBGMusic;
    public GameObject alreadywon;
    public GameObject alreadylost;
    public GameObject infoText;
    private int onCount = 0;
    private int winPoints = 0;
    private int highScore = 0;
    public GameObject isInputEnabled;
    [SerializeField] Text pointsCount;
    [SerializeField] Text highestScore;


    private void Start()
    {
       winPoints = PlayerPrefs.GetInt("Points");
        highScore = PlayerPrefs.GetInt("HighScore");
        isInputEnabled.SetActive(true);
    }

    private void Update()
    {
        pointsCount.text = winPoints.ToString("Points: 0");
        highestScore.text = highScore.ToString("High Score: 0");
        PlayerPrefs.SetInt("Points", winPoints);

        if (winPoints > highScore)
        {
            PlayerPrefs.SetInt("HighScore", winPoints);
        }
    }
    
    
    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == SwitchCount)
        {
            alreadywon.SetActive(true);
            winPoints = winPoints + 1;
            isInputEnabled.SetActive(false);
        }
        if (alreadylost.activeInHierarchy)
        {
            winText.SetActive(false);
            winSound.SetActive(false);
            muteBGMusic.SetActive(false);
        }
    }

    public IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(4.178f);
        SceneManager.LoadScene(1);
    }
}
