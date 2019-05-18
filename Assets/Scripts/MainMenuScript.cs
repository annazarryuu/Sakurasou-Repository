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
        
    }

    public void settingButton()
    {
        SceneManager.LoadScene("Setting");
    }

    public void helpButton()
    {
        
    }

    public void quitButton()
    {
        
    }
}
