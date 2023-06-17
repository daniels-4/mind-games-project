using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ConnectToGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("player attempting to connect");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("player has quit the game");
    }
}
