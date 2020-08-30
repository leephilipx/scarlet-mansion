using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Safe1code : MonoBehaviour
{
    public GameObject Safe1Image;
    public Image scopeImage;
    public GameObject playerObject;
    public bool scopegone;
    public Inventory inventory;
    public Snorlax snorlax;
    public GameObject CanvasClue2;

    // Start is called before the first frame update
    void Start()
    {
        scopegone = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Safe1Image.activeSelf && !CanvasClue2.activeSelf) HidesafeImage();
    }

    public void scopeG()
    {
        scopegone = true;
    }
    public void ShowsafeImage()
    {
        if (!scopegone )
        {
            scopeImage.enabled = true;
        }
        Safe1Image.SetActive(true);
        //GetComponent<AudioSource>().PlayOneShot(pickupSound);
        playerObject.GetComponent<exitFungus>().enabled = false;
        playerObject.GetComponent<inFungus>().enabled = true;
    }


    public void HidesafeImage()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.05f);
        Safe1Image.SetActive(false);
        playerObject.GetComponent<exitFungus>().enabled = true;
        playerObject.GetComponent<inFungus>().enabled = false;
        if (!scopegone)
        {
            scopeImage.enabled = false;
        }
    }
}
