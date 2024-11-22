using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame(){
        Debug.Log($"Paula's Room");
        SceneManager.LoadScene("Paula's Room");


    }//end NewGame Function

    public void SettingsMenu(){
        Debug.Log($"Open Settings ");

    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log($"Game ended");

    }
}
