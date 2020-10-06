using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
   public SeleccionarEscena seleccionarEscena;
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
        Cursor.visible = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    public void CargarEscena(int index)
    {
        seleccionarEscena.LoadScene(index);
        Time.timeScale = 1f;
    }

    public void SalirJuego()
    {
        seleccionarEscena.LoadQuit();
    }
}
