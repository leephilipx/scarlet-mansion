using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue10 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject masao;
    public GameObject rinni;

    public void ShowNoteImage()
    {
        Destroy(gameObject);
        masao.GetComponent<masaoC>().flight = true;
        rinni.GetComponent<RinniCon>().flight = true;
        inventory.enClue10();
    }
}
