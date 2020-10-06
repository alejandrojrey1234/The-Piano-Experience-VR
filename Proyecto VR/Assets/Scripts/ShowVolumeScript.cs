using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowVolumeScript : MonoBehaviour
{
    TMP_Text text;
    void Start()
    {
        text = GetComponent<TMP_Text>();   
    }

    public void TextPercentageUpdate(float value)
    {
        text.text = Mathf.RoundToInt(value + 100).ToString() + "%";
    }

    public void TextLinearUpdate(float value)
    {
        text.text = Mathf.RoundToInt(value).ToString();
    }
}
