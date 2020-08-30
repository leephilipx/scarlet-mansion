using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VisualNovelIntro: MonoBehaviour
{
    public GameObject CanvasInstructions1;
    public GameObject ImageFade;
    public Flowchart myFlowchart;
    public Image BackgroundImage;
    public bool EndSceneVar;
    private int BackgroundImgNo;
    private bool RunOnce = true;
    private float alpha = 0.0f;
    public float FadeSpeed = 400.0f;
    
    // Update is called once per frame
    void Update()
    {
        EndSceneVar = myFlowchart.GetBooleanVariable("EndSceneVar");
        BackgroundImgNo = myFlowchart.GetIntegerVariable("BackgroundImgNo");
        if (EndSceneVar && RunOnce) RunInstructions1();
        if (alpha < 255 && !RunOnce) RunInstructions2();
        // Black background
        if (BackgroundImgNo == 0) BackgroundImage.sprite = Resources.Load<Sprite>("UIVisualNovel/Sprites/intro-background-6");
        else BackgroundImage.sprite = Resources.Load<Sprite>("UIVisualNovel/Sprites/intro-background-" + BackgroundImgNo.ToString());
    }

    void RunInstructions1()
    {
        RunOnce = false;
        CanvasInstructions1.SetActive(true);
        //myFlowchart.SetBooleanVariable("EndSceneVar", false);
    }

    void RunInstructions2()
    {
        alpha += FadeSpeed * Time.deltaTime;
        ImageFade.GetComponent<Image>().color = new Color32(0, 0, 0, (byte)alpha);
        if (alpha > 250) SceneManager.LoadScene(3);
    }
}
