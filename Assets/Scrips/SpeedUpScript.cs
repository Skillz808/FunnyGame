using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpScript : MonoBehaviour
{
    //int[] speedUpValues = new int[] { 4, 7, 12, 18, 24, 31, 38, 43, 50, 60 };
    float currentTime;
    public AudioSource winSound;
    public AudioSource lostSound;
    public AudioSource BGMusic;
    public AudioSource winSpeedUp;
    private int winPoints;
    public GameObject isSpeedUp;

    public void Start()
    {
        currentTime = PlayerPrefs.GetFloat("currentTime");
        winPoints = PlayerPrefs.GetInt("Points");
        if (winPoints <= 0)
        {
            currentTime = 5f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1f);
            PlayerPrefs.SetFloat("losePitch", 1f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1f);
        }
        winSound.pitch = PlayerPrefs.GetFloat("winPitch");
        lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
        BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
        winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
    }

    public void Update()
    {
        if (winPoints == 3)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 6)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 11)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 17)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 23)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 30)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 37)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 42)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 49)
        {
            isSpeedUp.SetActive(true);
        }
        if (winPoints == 59)
        {
            isSpeedUp.SetActive(true);
        }

        if (winPoints == 4)
        {
            currentTime = 5 / 1.20f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.025f);
            PlayerPrefs.SetFloat("losePitch", 1.025f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.025f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.025f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 7)
        {
            currentTime = 5 / 1.40f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.05f);
            PlayerPrefs.SetFloat("losePitch", 1.05f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.05f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.05f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 12)
        {
            currentTime = 5 / 1.60f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.075f);
            PlayerPrefs.SetFloat("losePitch", 1.075f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.075f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.075f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 18)
        {
            currentTime = 5 / 1.80f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.10f);
            PlayerPrefs.SetFloat("losePitch", 1.10f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.10f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.10f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 24)
        {
            currentTime = 5 / 2f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.125f);
            PlayerPrefs.SetFloat("losePitch", 1.125f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.125f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.125f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 31)
        {
            currentTime = 5 / 2.20f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.15f);
            PlayerPrefs.SetFloat("losePitch", 1.15f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.15f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.15f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 38)
        {
            currentTime = 5 / 2.40f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.175f);
            PlayerPrefs.SetFloat("losePitch", 1.175f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.175f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.175f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 43)
        {
            currentTime = 5 / 2.60f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.20f);
            PlayerPrefs.SetFloat("losePitch", 1.20f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.20f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.20f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 50)
        {
            currentTime = 5 / 2.80f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.225f);
            PlayerPrefs.SetFloat("losePitch", 1.225f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.225f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.225f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
        else if (winPoints == 60)
        {
            currentTime = 5 / 3.00f;
            PlayerPrefs.SetFloat("currentTime", currentTime);
            PlayerPrefs.SetFloat("winPitch", 1.25f);
            PlayerPrefs.SetFloat("losePitch", 1.25f);
            PlayerPrefs.SetFloat("BGMusicPitch", 1.25f);
            PlayerPrefs.SetFloat("winSpeedUpPitch", 1.25f);
            winSound.pitch = PlayerPrefs.GetFloat("winPitch");
            lostSound.pitch = PlayerPrefs.GetFloat("losePitch");
            BGMusic.pitch = PlayerPrefs.GetFloat("BGMusicPitch");
            winSpeedUp.pitch = PlayerPrefs.GetFloat("winSpeedUpPitch");
        }
    }
}
