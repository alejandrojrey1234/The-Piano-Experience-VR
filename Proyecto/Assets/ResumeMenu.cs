using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeMenu : MonoBehaviour
{
    public GameObject resumeMenu;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            resumeMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
