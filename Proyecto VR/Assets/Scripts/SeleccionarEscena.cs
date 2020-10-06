using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SeleccionarEscena : MonoBehaviour
{
    public Animator transition;
    public GameObject loadscene;    
    //public TMP_Text tmp_text;

    void Awake()
    {
        loadscene.SetActive(true);   
    }
    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(loadScene(sceneIndex));
    }

    public void LoadQuit()
    {
        StartCoroutine(loadQuit());
    }
    IEnumerator loadQuit()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
    }
    IEnumerator loadScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
           /*animation.SetActive(true);
           tmp_text.text = "Loading. ";
           yield return new WaitForSeconds(.5f);
           tmp_text.text = "Loading. .";
           yield return new WaitForSeconds(.5f);
           tmp_text.text = "Loading. . .";*/
        yield return null;
        }
    }
}
