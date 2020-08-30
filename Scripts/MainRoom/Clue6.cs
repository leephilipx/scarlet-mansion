using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue6 : MonoBehaviour
{
    public Inventory inventory;

    public void ShowNoteImage()
    {
        Destroy(gameObject);
        inventory.enClue6();
    }
}
