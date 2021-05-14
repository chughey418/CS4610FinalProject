using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // if the user selects play, load the scene
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }
    
    // if the user quits, load the main menu
    public void QuitGame() {
        Debug.Log("Quit!");
        Application.Quit();
        SceneManager.LoadScene(0);
    }
}
