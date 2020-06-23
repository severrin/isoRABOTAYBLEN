using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGameI()
    {
        SceneManager.LoadScene("GAMEi");
    }

    public void PlayGameSO()
    {
        SceneManager.LoadScene("GAMEso");
    }
    public void PlayGameLA()
    {
        SceneManager.LoadScene("GAMEla");
    }

    public void PlayGameT()
    {
        SceneManager.LoadScene("GAMEt");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
