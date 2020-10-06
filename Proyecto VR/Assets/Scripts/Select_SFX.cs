using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Select_SFX : MonoBehaviour
{
    AudioMixer mixer;
    public TMP_Text str;

    void Update()
    {
        SetMixers(str);
        SetSFX(str);
    }
    public void SetSFX(TMP_Text str)
    {
       // if( str.text == mixer.FindMatchingGroups(str.text)[0])
        {

        }
       
    }

    void SetMixers(TMP_Text str)
    {
        mixer = Resources.Load("Master") as AudioMixer;
        GetComponent<AudioSource>().outputAudioMixerGroup = mixer.FindMatchingGroups(str.text)[0];
    }
}
