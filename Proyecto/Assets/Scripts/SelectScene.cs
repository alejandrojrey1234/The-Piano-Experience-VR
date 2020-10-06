using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void concierto()
    {
        SceneManager.LoadScene(2);
    }

    public void casa()
    {
        SceneManager.LoadScene(3);
    }

    public void synthwave()
    {
        SceneManager.LoadScene(4);
    }

    public void parque()
    {
        SceneManager.LoadScene(5);
    }
    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

}
