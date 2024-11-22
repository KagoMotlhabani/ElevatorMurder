using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void NewGame(){
        Debug.Log($"New Game Started");

    }//end NewGame Function

    public void LoadGame(){
        Debug.Log($"Choose Save File");

    }
    
    public void SettingsMenu(){
        Debug.Log($"Open Settings ");

    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log($"Game ended");

    }
}
