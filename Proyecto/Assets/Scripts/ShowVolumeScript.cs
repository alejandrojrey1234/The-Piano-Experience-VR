using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowVolumeScript : MonoBehaviour
{
    TMP_Text percentageText;
    void Start()
    {
        percentageText = GetComponent<TMP_Text>();   
    }

    public void TextUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value + 100) + "%";
    }
}
