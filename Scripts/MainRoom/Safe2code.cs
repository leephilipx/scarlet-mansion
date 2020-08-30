using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Safe2code : MonoBehaviour
{
    public GameObject SafeImageClose;
    public GameObject SafeImageOpen;
    public Image c4;  
    public GameObject playerObject;

    public bool open;
    public bool cg;

    public Inventory inventory;
    public Snorlax snorlax;
    public GameObject CanvasClue4;


    // Start is called before the first frame update
    void Start()
    {
        c4.enabled = false;
        open = false;
        cg = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (SafeImageClose.activeSelf || SafeImageOpen.activeSelf) && !CanvasClue4.activeSelf) HidesafeImage();
    }

    public void ShowsafeImage()
    {
        if (open == false)
        {
            SafeImageClose.SetActive(true);
        }
        else
        {
            SafeImageOpen.SetActive(true);
            if (cg == false)
            {
                c4.enabled = true;
            }
        }
        //GetComponent<AudioSource>().PlayOneShot(pickupSound);
        playerObject.GetComponent<exitFungus>().enabled = false;
        playerObject.GetComponent<inFungus>().enabled = true;
    }

    public void HidesafeImage()
    {
        if(cg)
        {

            snorlax.clue4G();
        }
        StartCoroutine(delay());
        //GetComponent<AudioSource>().PlayOneShot(putAwaySound);
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.05f);
        SafeImageOpen.SetActive(false);
        SafeImageClose.SetActive(false);
        playerObject.GetComponent<exitFungus>().enabled = true;
        playerObject.GetComponent<inFungus>().enabled = false;
        if (cg == false)
        {
            c4.enabled = false;
        }
    }

        public void openSafe()
    {
        SafeImageOpen.SetActive(false);
        SafeImageClose.SetActive(false);
        if (!cg)
        {
            c4.enabled = true;
        }
        SafeImageOpen.SetActive(true);
        open = true;
    }

    public void cgone()
    {
        cg = true;
    }
}
