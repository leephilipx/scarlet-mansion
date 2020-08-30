using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SettingMenuOwn : MonoBehaviour
{
    // Settings menu UI objects
    public Dropdown DropdownGraphics;
    public Slider SliderMouseS;
    public Slider SliderVolume;
    public Flowchart myFlowchart;

    // Dropdown and graphics indexes are reversed
    private readonly int[] Reverse = { 2, 1, 0 };
    public int DefaultQuality = 1;
    public float DefaultMouseSensitivity = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.SetQualityLevel(DefaultQuality);
        SliderMouseS.value = DefaultMouseSensitivity;
        DropdownGraphics.value = Reverse[QualitySettings.GetQualityLevel()];
        SliderVolume.value = AudioListener.volume;
        DropdownGraphics.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        SliderMouseS.onValueChanged.AddListener(delegate { ValueChangeCheckMouseS(); });
        SliderVolume.onValueChanged.AddListener(delegate { ValueChangeCheckVolume(); });
    }

    public void DropdownValueChanged()
    {
        QualitySettings.SetQualityLevel(Reverse[DropdownGraphics.value]);
    }

    public void ValueChangeCheckMouseS()
    {
        myFlowchart.SetFloatVariable("MouseSensitivity", SliderMouseS.value);
    }

    public void ValueChangeCheckVolume()
    {
        AudioListener.volume = SliderVolume.value;
    }
}
