using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class PauseMenuOwn : MonoBehaviour
{
    // Settings menu UI objects
    public Dropdown DropdownGraphics;
    public Slider SliderMouseS;
    public Slider SliderVolume;
    public Flowchart myFlowchart;

    // Dropdown and graphics indexes are reversed
    private readonly int[] Reverse = { 2, 1, 0 };

    // For pause menu only
    public Toggle ToggleCrosshair;
    public GameObject CanvasPause;
    public GameObject CanvasConfirmation;
    public GameObject CanvasHowToPlay;
    /*public GameObject CanvasInventory;
    public GameObject CanvasSafe1Zoom;
    public GameObject CanvasSafe2Close;
    public GameObject CanvasSafe2Open;
    public GameObject CanvasPuzzle;*/
    public GameObject PlayerObject;
    public GameObject SayDialogCustom;
    bool PauseMenuEnabled = false;
    private bool isPrevCursorVisible = false;

    public bool tempDisable = false;

    // Start is called before the first frame update
    void Start()
    {
        DropdownGraphics.value = Reverse[QualitySettings.GetQualityLevel()];
        SliderVolume.value = AudioListener.volume;
        DropdownGraphics.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
        SliderMouseS.onValueChanged.AddListener(delegate { ValueChangeCheckMouseS(); });
        SliderVolume.onValueChanged.AddListener(delegate { ValueChangeCheckVolume(); });
    }

    // Update is called once per frame
    void Update()
    {
        if (!tempDisable)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && (PlayerObject.GetComponent<exitFungus>().enabled || CanvasPause.activeSelf))
            // !CanvasConfirmation.activeSelf && !CanvasInventory.activeSelf
            // && !CanvasSafe1Zoom.activeSelf && !CanvasSafe2Close.activeSelf && !CanvasSafe2Open.activeSelf && !CanvasPuzzle.activeSelf)
            {
                PauseMenuEnabled = !PauseMenuEnabled;

                if (PauseMenuEnabled)
                {
                    CanvasPause.SetActive(true);
                    Time.timeScale = 0;
                    SayDialogCustom.GetComponent<DialogInput>().enabled = false;
                    // Saves previous cursor state to match after screen is closed
                    isPrevCursorVisible = PlayerObject.GetComponent<exitFungus>().enabled;
                    PlayerObject.GetComponent<exitFungus>().enabled = false;
                    PlayerObject.GetComponent<inFungus>().enabled = true;
                }
                else
                {
                    CanvasPause.SetActive(false);
                    Time.timeScale = 1;
                    SayDialogCustom.GetComponent<DialogInput>().enabled = true;
                    if (isPrevCursorVisible)
                    {
                        PlayerObject.GetComponent<exitFungus>().enabled = true;
                        PlayerObject.GetComponent<inFungus>().enabled = false;
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape) && CanvasConfirmation.activeSelf) OnNo();
        }
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

    public void OnCloseMenu()
    {
        PauseMenuEnabled = false;
        CanvasPause.SetActive(false);
        Time.timeScale = 1;
        SayDialogCustom.GetComponent<DialogInput>().enabled = true;
        if (isPrevCursorVisible)
        {
            PlayerObject.GetComponent<exitFungus>().enabled = true;
            PlayerObject.GetComponent<inFungus>().enabled = false;
        }
    }

    public void OnHowToPlay()
    {
        CanvasHowToPlay.SetActive(true);
        CanvasPause.SetActive(false);   
        Time.timeScale = 0;
    }

    public void OnQuitGame()
    {
        PauseMenuEnabled = false;
        CanvasConfirmation.SetActive(true);
        CanvasPause.SetActive(false);
    }

    public void OnYes()
    {
        Application.Quit();
    }

    public void OnNo()
    {
        PauseMenuEnabled = true;
        CanvasConfirmation.SetActive(false);
        CanvasPause.SetActive(true);
    }

    public void CrosshairBool()
    {
        PlayerObject.GetComponent<Interact>().CrosshairBool = ToggleCrosshair.isOn;
        PlayerObject.GetComponent<inFungus>().CrosshairBool = ToggleCrosshair.isOn;
        PlayerObject.GetComponent<exitFungus>().CrosshairBool = ToggleCrosshair.isOn;
    }
}
