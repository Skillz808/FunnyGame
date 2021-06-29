using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHighScores : MonoBehaviour
    
{

    private int OldHS = 0;
    private int NewHS = 0;
    [SerializeField] Text oldHighScore;
    [SerializeField] Text newHighScore;

    // Start is called before the first frame update
    void Start()
    {
       OldHS = PlayerPrefs.GetInt("OldHS");
       NewHS = PlayerPrefs.GetInt("HighScore");
       oldHighScore.text = OldHS.ToString("Old: 0");
       newHighScore.text = NewHS.ToString("New: 0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
