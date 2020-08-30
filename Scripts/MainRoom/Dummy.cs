using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dummy : MonoBehaviour
{
    public GameObject player;
    public GameObject Dummy1Inactive;
    public GameObject Dummy2Inactive;
    public GameObject Dummy3Inactive;    
    public GameObject Dummy4Inactive;
    public GameObject Dummy5Inactive;
    public GameObject Dummy6Inactive;
    public GameObject Dummy7Inactive;
    public GameObject Dummy8Inactive;
    public GameObject Dummy9Inactive;
    public GameObject Dummy10Inactive;
    public GameObject Dummy11Inactive;
    public GameObject Dummy12Inactive;

    public void ShowNoteImage()
    {
        if (player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy1Inactive.SetActive(false);
            Dummy1Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage2()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy2Inactive.SetActive(false);
            Dummy2Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage3()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy3Inactive.SetActive(false);
            Dummy3Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage4()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy4Inactive.SetActive(false);
            Dummy4Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage5()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy5Inactive.SetActive(false);
            Dummy5Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage6()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy6Inactive.SetActive(false);
            Dummy6Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage7()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy7Inactive.SetActive(false);
            Dummy7Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage8()
    {
        if(player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy8Inactive.SetActive(false);
            Dummy8Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage9()
    {
        if (player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy9Inactive.SetActive(false);
            Dummy9Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage10()
    {
        if (player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy10Inactive.SetActive(false);
            Dummy10Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage11()
    {
        if (player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy11Inactive.SetActive(false);
            Dummy11Inactive.SetActive(true);
        }
    }
    public void ShowNoteImage12()
    {
        if (player.GetComponent<exitFungus>().enabled == true)
        {
            Dummy12Inactive.SetActive(false);
            Dummy12Inactive.SetActive(true);
        }
    }
}