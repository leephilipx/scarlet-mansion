using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue8 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject masao;
    public GameObject yuna;

    public void ShowNoteImage()
    { 
        Destroy(gameObject);
        masao.GetComponent<masaoC>().vA = true;
        yuna.GetComponent<yunaCon>().vA = true;
        inventory.enClue8();
    }
}
