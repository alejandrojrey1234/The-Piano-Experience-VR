using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq.Expressions;

public class music_manager : MonoBehaviour
{
    public AudioClip[] list;
    public int songNumber;
    [SerializeField]
    public AudioSource audioSource;
    public TMP_Text texto;

    // Start is called before the first frame update
    void Start()
    {

        list = new AudioClip[] {
           (AudioClip)Resources.Load("Musica_numerada/Butterfly Effect - Travis Scott"),
           (AudioClip)Resources.Load("Musica_numerada/Giorno's Theme (Piano Cover)"),
           (AudioClip)Resources.Load("Musica_numerada/Santo & Johnny - Sleep walk"),
           (AudioClip)Resources.Load("Musica_numerada/Anakin's Betrayal (Piano Cover)"),
           (AudioClip)Resources.Load("Musica_numerada/dusty"),
           (AudioClip)Resources.Load("Musica_numerada/Endless Mind"),
           (AudioClip)Resources.Load("Musica_numerada/Just Wanted to Tell You")
      };
        songNumber = UnityEngine.Random.Range(0, list.Length);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = list[songNumber];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.isPlaying == false)
        {
            songNumber = UnityEngine.Random.Range(0, list.Length);

            audioSource.clip = list[songNumber];
            audioSource.Play();
        }
        texto.text = "Music: " + audioSource.clip.name;
    }   
    /*public void Playear()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.UnPause();
            Debug.Log("play");
        }
    }

   /* public void Pausar()
    {
        //if (audioSource.isPlaying)
        //{
            audioSource.Pause();
            Debug.Log("pausa");
        //}
    }

    public void Back()
    {
       Debug.Log("play anterior");
       audioSource.Stop();
      if(audioSource.time < 2.5)
        {
            audioSource.clip = list[songNumber--];
            Debug.Log("entra");
            //audioSource.Play();

        }
        
        audioSource.Play();
    }


    public void Skip()
    {
        audioSource.clip = list[songNumber++];
        audioSource.Play();
        Debug.Log("skip");
    }*/
}
