using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text winText; // Change to UnityEngine.UI.Text
    // Remove the unnecessary 'sceneManager' variable

    void Start()
    {
        winText.enabled = false; // Hide the "You Win" message initially
    }

    public void WinGame()
    {
        winText.enabled = true; // Show the "You Win" message
        Time.timeScale = 0; // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // Unpause the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene
    }
}