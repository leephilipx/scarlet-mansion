using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue4 : MonoBehaviour
{
    public Safe2code sf2;
    public Inventory inventory;
    public void ShowNoteImage()
    {
        Destroy(gameObject);
        sf2.cgone();
        //inventory.ShowClue4();
        //inventory.enableClue4 = true;
        inventory.enClue4();

    }
}
