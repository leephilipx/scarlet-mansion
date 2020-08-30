using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBook : MonoBehaviour
{
    public GameObject BGFrame;
    public GameObject MainPage0;
    public GameObject MainPage1;
    public GameObject MainPage2;
    public GameObject MainPage3;
    public GameObject MainPage4;
    private int CluePageNo = 0;
    private readonly bool[] bgf = { false, true, true, true, false };
    private readonly bool[] cp0 = { true, false, false, false, false };
    private readonly bool[] cp1 = { false, true, false, false, false };
    private readonly bool[] cp2 = { false, false, true, false, false };
    private readonly bool[] cp3 = { false, false, false, true, false };
    private readonly bool[] cp4 = { false, false, false, false, true };
    public GameObject DialogueTextObject;
    public GameObject LeftButton;
    public GameObject RightButton;
    public Text PageNumberText1;
    public Text PageNumberText2;
    public Text DialogueText1;
    public Text DialogueText2;
    public Text DialogueText3;
    public Text DialogueText4;
    public Text DialogueText5;
    public Text DialogueText6;
    private int DialoguePageNo = 0;
    private readonly bool[] dp0 = { true, false, false, };
    private readonly bool[] dp1 = { false, true, false, };
    private readonly bool[] dp2 = { false, false, true, };
    private bool inDialogue = false;

    void Start()
    {
        CluePageHandler(0);
        DialogueTextObject.SetActive(false);
    }

    public void PrevPage()
    {
        if (inDialogue)
        {
            DialoguePageNo -= 1;
            DialoguePageHandler(DialoguePageNo);
        }
        else
        {
            CluePageNo -= 1;
            CluePageHandler(CluePageNo);
        }
    }

    public void NextPage()
    {
        if (inDialogue)
        {
            DialoguePageNo += 1;
            DialoguePageHandler(DialoguePageNo);
        }
        else
        {
            CluePageNo += 1;
            CluePageHandler(CluePageNo);
        }
    }
    
    void CluePageHandler(int CluePageNo)
    {
        MainPage0.SetActive(cp0[CluePageNo]);
        MainPage1.SetActive(cp1[CluePageNo]);
        MainPage2.SetActive(cp2[CluePageNo]);
        MainPage3.SetActive(cp3[CluePageNo]);
        MainPage4.SetActive(cp4[CluePageNo]);
        BGFrame.SetActive(bgf[CluePageNo]);
    }

    void DialoguePageHandler(int DialoguePageNo)
    {
        DialogueText1.enabled = dp0[DialoguePageNo];
        DialogueText2.enabled = dp0[DialoguePageNo];
        DialogueText3.enabled = dp1[DialoguePageNo];
        DialogueText4.enabled = dp1[DialoguePageNo];
        DialogueText5.enabled = dp2[DialoguePageNo];
        DialogueText6.enabled = dp2[DialoguePageNo];
        LeftButton.SetActive(!dp0[DialoguePageNo]);
        RightButton.SetActive(!dp2[DialoguePageNo]);
        PageNumberText1.text = "Page " + (2 * DialoguePageNo + 1).ToString() + " of 6";
        PageNumberText2.text = "Page " + (2 * DialoguePageNo + 2).ToString() + " of 6";
    }

    public void ViewDialogue()
    {
        inDialogue = true;
        DialoguePageHandler(DialoguePageNo);
        DialogueTextObject.SetActive(true);
        MainPage1.SetActive(false);
        
    }

    public void CloseDialogue()
    {
        inDialogue = false;
        DialogueTextObject.SetActive(false);
        LeftButton.SetActive(true);
        RightButton.SetActive(true);
        MainPage1.SetActive(true);
    }
}
