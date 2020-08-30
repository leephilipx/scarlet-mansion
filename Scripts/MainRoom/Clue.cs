using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public Inventory inventory;
    public Snorlax snorlax;

    public void ShowNoteImage()
    {
        Destroy(gameObject);
        inventory.enClue1();
        snorlax.clue1G();
    }
}
