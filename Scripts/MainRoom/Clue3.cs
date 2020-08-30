using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue3 : MonoBehaviour
{
    public Inventory inventory;
    public Snorlax snorlax;

    public void ShowNoteImage()
    {

        Destroy(gameObject);
        inventory.enClue3();
        snorlax.clue3G();
    }
}
