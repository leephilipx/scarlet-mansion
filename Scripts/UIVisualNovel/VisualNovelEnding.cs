using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class VisualNovelEnding: MonoBehaviour
{
    public Flowchart myFlowchart;
    public Image BackgroundImage;
    public Text text2c;
    public Text text2w;
    public Text text3c;
    public Text text3w;
    private int seconds;
    private int minutes;
    private int BackgroundImgNo;
    private int enitiocount;
    public string url;

    void Start()
    {
        seconds = myFlowchart.GetIntegerVariable("TimeTaken");
        minutes = (int)(seconds / 60);
        seconds -= minutes * 60;
        text2c.text = "Time taken: " + minutes.ToString() + " min " + seconds.ToString() + " s";
        text2w.text = "Time taken: " + minutes.ToString() + " min " + seconds.ToString() + " s";
        enitiocount = myFlowchart.GetIntegerVariable("EnitioCount");
        text3c.text = "Enitio collectibles: " + enitiocount.ToString() + "/6";
        text3w.text = "Enitio collectibles: " + enitiocount.ToString() + "/6";
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundImgNo = myFlowchart.GetIntegerVariable("BackgroundImgNo");
        BackgroundImage.sprite = Resources.Load<Sprite>("UIVisualNovel/Sprites/ending-background-" + BackgroundImgNo);
    }

    public void GameEnd()
    {
        if (url != "") Application.OpenURL(url);
        Application.Quit();
    }
}
