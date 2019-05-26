using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    
    public void toLoadGame()
    {
       SceneManager.LoadScene("Load");
    }

    public void toSaveGame()
    {
        SceneManager.LoadScene("Save");
    }

    public void toSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void toHelp()
    {
        SceneManager.LoadScene("Help");        
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void toHistory()
    {
       SceneManager.LoadScene("History");
    }
    
    public void toLoadGameFromGame()
    {
       SceneManager.LoadScene("LoadFromGame");
    }

    public void toSettingFromGame()
    {
        SceneManager.LoadScene("SettingFromGame");
    }

    public void toHelpFromGame()
    {
        SceneManager.LoadScene("HelpFromGame");        
    }

    public void toDesktop()
    {
        Application.Quit();
        // SceneManager.LoadScene("Desktop"); 
    }
}