using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject CanvasFade;
    public GameObject ImageFade;
    public float FadeSpeed = 400.0f;
    public GameObject PlayerObject;
    public GameObject CanvasHowToPlay;
    public GameObject UIHandler;
    public Flowchart myFlowchart;
    private bool RunFade = true;
    private float alpha = 255.0f;
    private float timer = 0.0f;
    public int seconds;
    private bool RunOnce = true;

    void Start()
    {
        PlayerObject.GetComponent<exitFungus>().enabled = false;
        PlayerObject.GetComponent<inFungus>().enabled = true;
        CanvasFade.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer);
        if (RunFade)
        {
            alpha -= FadeSpeed * Time.deltaTime;
            ImageFade.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)alpha);
            if (alpha < 1)
            {
                RunFade = false;
                CanvasFade.SetActive(false);
                CanvasHowToPlay.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && CanvasHowToPlay.activeSelf) CloseHowToPlay();
    }

    public void CloseHowToPlay()
    {
        CanvasHowToPlay.SetActive(false);
        Time.timeScale = 1;
        PlayerObject.GetComponent<exitFungus>().enabled = true;
        PlayerObject.GetComponent<inFungus>().enabled = false;
        if (RunOnce)
        {
            RunOnce = false;
            ImageFade.SetActive(false);
            UIHandler.GetComponent<PauseMenuOwn>().enabled = true;
        }
    }

    public void PassTimeTakenValue()
    {
        myFlowchart.SetIntegerVariable("TimeTaken", seconds);
        PlayerObject.GetComponent<exitFungus>().enabled = false;
        PlayerObject.GetComponent<inFungus>().enabled = true;
    }
}
