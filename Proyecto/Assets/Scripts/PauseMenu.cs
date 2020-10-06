using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuUI.SetActive(true);
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        //Cursor.visible = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
       // Cursor.visible = true;
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ScenesMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
