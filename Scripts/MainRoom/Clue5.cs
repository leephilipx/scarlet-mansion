using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue5 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject rinni;
    public GameObject umbrellaInactive;
    public GameObject player;
    public Snorlax snorlax;

    public void ShowNoteImage()
    {
        if (rinni.GetComponent<RinniCon>().talked)
        {
            Destroy(gameObject);
            inventory.enClue5();
            rinni.GetComponent<RinniCon>().picked = true;
            snorlax.clue5G();
        }
        else
        {
            if (player.GetComponent<exitFungus>().enabled == true)
            {
                umbrellaInactive.SetActive(false);
                umbrellaInactive.SetActive(true);
            }
        }
    }
}
