using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue2 : MonoBehaviour
{
    public Safe1code s1;
    public Inventory inventory;
    public Snorlax snorlax;
    public void ShowNoteImage()
    {

        Destroy(gameObject);
        //inventory.ShowClue2();
        //inventory.enableClue2 = true;
        inventory.enClue2();
        snorlax.clue2G();
        s1.scopeG();
    }
}
