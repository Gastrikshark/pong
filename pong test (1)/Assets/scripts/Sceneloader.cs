using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void MultiPlayer()
    {
        SceneManager.LoadScene(0);
    }

    public void SinglePlayer()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
