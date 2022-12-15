using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // A reference to the pause menu UI game object
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the pause button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the game is currently paused, resume it
            if (Time.timeScale == 0)
            {
                Resume();
            }
            else
            {
                // Otherwise, pause the game
                Pause();
            }
        }
    }

    public void Resume()
    {
        // Hide the pause menu UI
        pauseMenuUI.SetActive(false);

        // Set the time scale back to 1, which will unpause the game
        Time.timeScale = 1;
    }

    void Pause()
    {
        // Show the pause menu UI
        pauseMenuUI.SetActive(true);

        // Set the time scale to 0, which will pause the game
        Time.timeScale = 0;
    }
}