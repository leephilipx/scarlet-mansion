using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snorlax : MonoBehaviour
{
    public bool clue0Get = false;
    public bool clue1Get = false;
    public bool clue2Get = false;
    public bool clue3Get = false;
    public bool clue4Get = false;
    public bool clue5Get = false;
    public bool rinnitalk = false;
    public bool rinnitalk2 = false;
    public GameObject player;
    public bool playerEntered;
    public GameObject notDone;
    public GameObject upstair;
    private bool runOnce = true;
    public GameObject UIHandler;
    public GameObject InventoryHandler;

    // Update is called once per frame
    void Update()
    {
        if (runOnce && clue0Get && clue1Get && clue2Get && clue3Get && clue4Get && clue5Get
            && rinnitalk && rinnitalk2 && player.GetComponent<exitFungus>().enabled) StartCoroutine(waiter());
        if (playerEntered) notDone.SetActive(true);
        else notDone.SetActive(false);
    }

    IEnumerator waiter()
    {
        Debug.Log("In snorlax");
        player.GetComponent<Interact>().tempDisable = true;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = true;
        InventoryHandler.GetComponent<Inventory>().tempDisable = true;
        runOnce = false;
        yield return new WaitForSeconds(2);
        upstair.SetActive(true);
        yield return new WaitForSeconds(1);
        player.GetComponent<Interact>().tempDisable = false;
        UIHandler.GetComponent<PauseMenuOwn>().tempDisable = false;
        InventoryHandler.GetComponent<Inventory>().tempDisable = false;
        Destroy(gameObject);
    }

    public void clue0G()
    {
        clue0Get = true;
    }

    public void clue1G()
    {
        clue1Get = true;
    }

    public void clue2G()
    {
        clue2Get = true;
    }

    public void clue3G()
    {
        clue3Get = true;
    }

    public void clue4G()
    {
        clue4Get = true;
    }

    public void clue5G()
    {
        clue5Get = true;
    }

    public void rinnit()
    {
        rinnitalk = true;
    }

    public void rinnitNOT()
    {
        rinnitalk = false;
    }

    public void rinnit2()
    {
        rinnitalk2 = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)     //player has collided with trigger
        {
            playerEntered = true;
            Debug.Log("Collide");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)     //player has exited trigger
        {
            playerEntered = false;
            // hide interact message as player may not have been looking at object when they left
            Debug.Log("Exit");
        }
    }
}
