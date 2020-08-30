using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue9 : MonoBehaviour
{
    public Inventory inventory;
    public UnlockDoor ud;
    public GameObject CanvasPuzzle;

    public void ShowNoteImage()
    {
        CanvasPuzzle.SetActive(false);
        Destroy(gameObject);
        inventory.enClue9();
        ud.keyg();
    }
}
