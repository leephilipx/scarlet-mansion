using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue7 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject Tatsumi;

    public void ShowNoteImage()
    {
        Destroy(gameObject);
        inventory.enClue7();
        Tatsumi.GetComponent<TatsumiC>().picked = true;
    }
}
