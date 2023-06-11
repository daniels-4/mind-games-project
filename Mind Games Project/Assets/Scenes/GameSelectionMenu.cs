using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectionMenu : MonoBehaviour
{
    public void GameSelectDotty()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GameSelectOther()
    {
        // do nothing
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0); // first scene, main menu
    }
}
