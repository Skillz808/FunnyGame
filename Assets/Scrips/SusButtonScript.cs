using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SusButtonScript : MonoBehaviour
{
    public Sprite newButtonImage;
    public Button button;
    public AudioSource deathSound;

    public void ChangeButtonImage()
    {
        button.image.sprite = newButtonImage;
    }

    public void playSoundEffect()
    {
        deathSound.Play();
    }

}
