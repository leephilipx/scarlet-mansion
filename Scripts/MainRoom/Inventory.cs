using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool inventoryShown = false;
    public bool showEnabled = false;

    public GameObject tatsumi;
    public GameObject allclues;
    public GameObject readysolve;
    public GameObject InventoryHandler;

    public GameObject PlayerObject;
    public GameObject CanvasInventory;
    public GameObject CanvasClue0;
    public GameObject CanvasClue1;
    public GameObject CanvasClue2;
    public GameObject CanvasClue3;
    public GameObject CanvasClue4;
    public GameObject CanvasClue5;
    public GameObject CanvasClue6;
    public GameObject CanvasClue7;
    public GameObject CanvasClue8;
    public GameObject CanvasClue9;
    public GameObject CanvasClue10;

    public GameObject Clue0;
    public GameObject Clue1;
    public GameObject Clue2;
    public GameObject Clue3;
    public GameObject Clue4;
    public GameObject Clue5;
    public GameObject Clue6;
    public GameObject Clue7;
    public GameObject Clue8;
    public GameObject Clue9;
    public GameObject Clue10;
    public GameObject EnitoInv;
    public Text EnitioCountDisplay;
    public Flowchart myFlowchart;

    List<int> gotClue = new List<int>();
    List<int> enableClue = new List<int>();
    private int indexEnableClue = 0;
    private float xShift;
    private float yShift;
    private readonly float[] xPos = { 206f, 277.5f, 349f, 206f, 277.5f, 349f, 206f, 277.5f, 349f };
    private readonly float[] yPos = { 31f, 31f, 31f, -37.5f, -37.5f, -37.5f, -107f, -107f, -107f };  // -176.5f next row

    private int EnitioCount = 0;

    public bool masaostethoscope = false;
    public bool masaovitamina = false;
    public bool masaoticket = false;
    public bool yunagamedev = false;
    public bool yunavitamina = false;
    public bool rinniticket = false;
    public bool tatsumitimer = false;

    public bool tempDisable = false;
    public GameObject UIHandler;

    void Start()
    {
        CanvasInventory.SetActive(true);
        CanvasInventory.SetActive(false);
    }

    void Update()
    {
        if (!tempDisable)
        {
            if ((Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape)) && CanvasInventory.activeSelf)
            {
                if (showEnabled) backButton();
                else StartCoroutine(HideinventoryImage());
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && showEnabled) StartCoroutine(CloseClueCustom());

            if (Input.GetKeyDown(KeyCode.Q) && !showEnabled && PlayerObject.GetComponent<exitFungus>().enabled)
            {
                // inventoryShown = !inventoryShown;
                if (!CanvasInventory.activeSelf && PlayerObject.GetComponent<exitFungus>().enabled) ShowinventoryImage();
                // else if (!inventoryShown) StartCoroutine(HideinventoryImage());
            }
        }
        if (gotClue.Count == 11 && PlayerObject.GetComponent<exitFungus>().enabled)
        {
            if (!allclues.activeSelf) StartCoroutine(ALLCLUES());
            if (masaostethoscope && masaovitamina && masaoticket && yunagamedev
                && yunavitamina && rinniticket && tatsumitimer && !readysolve.activeSelf) StartCoroutine(READYSOLVE());
        }
    }

    IEnumerator CloseClueCustom()
    {
        yield return new WaitForSeconds(0.05f);
        backButton();
    }

    IEnumerator ALLCLUES()
    {
        PlayerObject.GetComponent<Interact>().tempDisable = true;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = true;
        tempDisable = true;
        yield return new WaitForSeconds(0.5f);
        PlayerObject.GetComponent<Interact>().tempDisable = false;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = false;
        tempDisable = false;
        tatsumi.GetComponent<TatsumiC>().done = true;
        allclues.SetActive(true);
    }

    IEnumerator READYSOLVE()
    {
        PlayerObject.GetComponent<Interact>().tempDisable = true;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = true;
        tempDisable = true;
        yield return new WaitForSeconds(0.5f);
        PlayerObject.GetComponent<Interact>().tempDisable = false;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = false;
        tempDisable = false;
        readysolve.SetActive(true);
        Debug.Log("READYYYYYYY");
    }


    public void ShowinventoryImage()
    {
        // Variable positions of inventory items
        indexEnableClue = 0;
        xShift = CanvasInventory.transform.position.x;
        yShift = CanvasInventory.transform.position.y;
        foreach (var ClueNo in enableClue)
        {
            var CluePosition = new Vector3(xPos[indexEnableClue] + xShift, yPos[indexEnableClue] + yShift, 0);
            switch (ClueNo)
            {
                case 0: Clue0.transform.position = CluePosition;  Clue0.SetActive(true);  break;
                case 1: Clue1.transform.position = CluePosition;  Clue1.SetActive(true);  break;
                case 2: Clue2.transform.position = CluePosition;  Clue2.SetActive(true);  break;
                case 3: Clue3.transform.position = CluePosition;  Clue3.SetActive(true);  break;
                case 4: Clue4.transform.position = CluePosition;  Clue4.SetActive(true);  break;
                case 5: Clue5.transform.position = CluePosition;  Clue5.SetActive(true);  break;
                case 6: Clue6.transform.position = CluePosition;  Clue6.SetActive(true);  break;
                case 7: Clue7.transform.position = CluePosition;  Clue7.SetActive(true);  break;
                case 8: Clue8.transform.position = CluePosition;  Clue8.SetActive(true);  break;
                case 9: Clue9.transform.position = CluePosition;  Clue9.SetActive(true);  break;
                case 10: Clue10.transform.position = CluePosition;  Clue10.SetActive(true);  break;
            }
            indexEnableClue += 1;
        }
        // Enitio Counter
        if (EnitioCount > 0)
        {
            EnitoInv.SetActive(true);
            EnitioCountDisplay.text = EnitioCount.ToString();
        }
        CanvasInventory.SetActive(true);
        PlayerObject.GetComponent<exitFungus>().enabled = false;
        PlayerObject.GetComponent<inFungus>().enabled = true;
    }

    IEnumerator HideinventoryImage()
    {
        yield return new WaitForSeconds(0.05f);
        showEnabled = false;
        CanvasInventory.SetActive(false);
        PlayerObject.GetComponent<exitFungus>().enabled = true;
        PlayerObject.GetComponent<inFungus>().enabled = false;
    }

    public void ShowClue0()
    {
        if (showEnabled == false)
        {
            CanvasClue0.SetActive(true);
            showEnabled = true;
        }
    }

    public void ShowClue1()
    {
        if (showEnabled == false)
        {
            CanvasClue1.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue2()
    {
        if (showEnabled == false)
        {
            CanvasClue2.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue3()
    {
        if (showEnabled == false)
        {
            CanvasClue3.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue4()
    {
        if (showEnabled == false)
        {
            CanvasClue4.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue5()
    {
        if (showEnabled == false)
        {
            CanvasClue5.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue6()
    {
        if (showEnabled == false)
        {
            CanvasClue6.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue7()
    {
        if (showEnabled == false)
        {
            CanvasClue7.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue8()
    {
        if (showEnabled == false)
        {
            CanvasClue8.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue9()
    {
        if (showEnabled == false)
        {
            CanvasClue9.SetActive(true);
            showEnabled = true;
        }
    }
    public void ShowClue10()
    {
        if (showEnabled == false)
        {
            CanvasClue10.SetActive(true);
            showEnabled = true;
        }
    }

    public void enClue0()
    {
        Thread.Sleep(200);
        enableClue.Add(0);
        gotClue.Add(0);
        ShowinventoryImage();
        ShowClue0();
    }

    public void enClue1()
    {
        Thread.Sleep(200);
        enableClue.Add(1);
        gotClue.Add(1);
        ShowinventoryImage();
        ShowClue1();
    }

    public void enClue2()
    {
        Thread.Sleep(200);
        enableClue.Add(2);
        gotClue.Add(2);
        ShowClue2();
    }
    public void enClue3()
    {
        Thread.Sleep(200);
        enableClue.Add(3);
        gotClue.Add(3);
        ShowinventoryImage();
        ShowClue3();
    }
    public void enClue4()
    {
        Thread.Sleep(200);
        enableClue.Add(4);
        gotClue.Add(4);
        ShowClue4();
    }
    public void enClue5()
    {
        Thread.Sleep(200);
        enableClue.Add(5);
        gotClue.Add(5);
        ShowinventoryImage();
        ShowClue5();
    }
    public void enClue6()
    {
        Thread.Sleep(200);
        enableClue.Add(6);
        gotClue.Add(6);
        ShowinventoryImage();
        ShowClue6();
    }
    public void enClue7()
    {
        Thread.Sleep(200);
        enableClue.Add(7);
        gotClue.Add(7);
        ShowinventoryImage();
        ShowClue7();
    }
    public void enClue8()
    {
        Thread.Sleep(200);
        enableClue.Add(8);
        gotClue.Add(8);
        ShowinventoryImage();
        ShowClue8();
    }
    public void enClue9()
    {
        Thread.Sleep(200);
        enableClue.Add(9);
        gotClue.Add(9);
        InventoryHandler.GetComponent<CatDoorHandler>().key9got = true;
        ShowinventoryImage();
        ShowClue9();
    }
    public void enClue10()
    {
        Thread.Sleep(200);
        enableClue.Add(10);
        gotClue.Add(10);
        ShowinventoryImage();
        ShowClue10();
    }

    public void disClue0()
    {
        if (enableClue.Contains(0)) enableClue.Remove(0);
        Clue0.SetActive(false);
    }

    public void disClue4()
    {
        if (enableClue.Contains(4)) enableClue.Remove(4);
        Clue4.SetActive(false);
    }

    public void disClue5()
    {
        if (enableClue.Contains(5)) enableClue.Remove(5);
        Clue5.SetActive(false);
    }

    public void disClue7()
    {
        if (enableClue.Contains(7)) enableClue.Remove(7);
        Clue7.SetActive(false);
        tatsumitimer = true;
    }

    public void disClue9()
    {
        if (enableClue.Contains(9)) enableClue.Remove(9);
        Clue9.SetActive(false);
    }

    public void Enitio(GameObject EnitioObject)
    {
        Destroy(EnitioObject);
        EnitioCount += 1;
        Thread.Sleep(200);
        ShowinventoryImage();
        myFlowchart.SetIntegerVariable("EnitioCount", EnitioCount);
    }

    public void backButton()
    {
        showEnabled = false;
        CanvasClue0.SetActive(false);
        CanvasClue1.SetActive(false);
        CanvasClue2.SetActive(false);
        CanvasClue3.SetActive(false);
        CanvasClue4.SetActive(false);
        CanvasClue5.SetActive(false);
        CanvasClue6.SetActive(false);
        CanvasClue7.SetActive(false);
        CanvasClue8.SetActive(false);
        CanvasClue9.SetActive(false);
        CanvasClue10.SetActive(false);
    }

    // Functions below are called from Fungus
    public void MasaoStethoscope() { masaostethoscope = true; }
    public void MasaoVitaminA() { masaovitamina = true; }
    public void MasaoTicket() { masaoticket = true; }
    public void YunaGameDev() { yunagamedev = true; }
    public void YunaVitaminA() { yunavitamina = true; }
    public void RinniTicket() { rinniticket = true; }
}
