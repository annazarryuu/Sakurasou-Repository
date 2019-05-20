using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void newGameButton()
    {
        SceneManager.LoadScene("MainGame");
    }
    
    public void loadGameButton()
    {
       SceneManager.LoadScene("Load");
    }

    public void settingButton()
    {
        SceneManager.LoadScene("Setting");
    }

    public void helpButton()
    {
        SceneManager.LoadScene("Help");        
    }

    public void quitButton()
    {
    }

    public void returnButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}