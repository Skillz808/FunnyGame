using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverReturn : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DebugGameOver()
    {
        SceneManager.LoadScene(3);
    }

    public void DebugGameOverHS()
    {
        SceneManager.LoadScene(5);
    }
}
