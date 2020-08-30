using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public string interactButton;
    Camera cam;
    public float interactDistance = 2f;

    // Layers of objects
    public LayerMask interactLayer;
    public LayerMask npcLayer;
    public LayerMask doorLayer;
    public LayerMask ignoreLayer;

    // Picture to show if you can interact or not
    public Image interactIcon; 
    public Text interactText;
    public Image npcIcon;
    public Text npcText;
    public Image doorIcon;
    public Text doorText;
    public Image crosshair;

    public bool isInteracting;
    public bool door = false;
    public GameObject Inventory;
    public GameObject Dummy;
    public GameObject player;

    public GameObject tatsuminame;
    public GameObject yunaname;
    public GameObject masaoname;
    public GameObject rinniname;
    public GameObject rabbitname;

    public bool tempDisable = false;
    public bool CrosshairBool = false;

    // Use this for initialization
    void Start()
    {
        if (interactIcon != null)
        {
            interactIcon.enabled = false;
            interactText.enabled = false;
            npcIcon.enabled = false;
            npcText.enabled = false;
            doorIcon.enabled = false;
            doorText.enabled = false;
        }
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        //Ray ray =  cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;      

        // Shoots a ray
        if (Physics.Raycast(ray, out hit, interactDistance, doorLayer))
        {
            // check if we are interacting
            doorIcon.enabled = true;
            doorText.enabled = true;
            if (CrosshairBool) crosshair.enabled = false;

            // if we click the interact button
            if (Input.GetButtonDown(interactButton) && player.GetComponent<exitFungus>().enabled && !tempDisable) // Temporary disable for 4 seconds by snorlax
            {
                if (hit.collider.CompareTag("LockedDoor")) Inventory.GetComponent<CatDoorHandler>().doorLocked();
                else if (hit.collider.CompareTag("YunaDoor")) Inventory.GetComponent<CatDoorHandler>().doorYuna();
                else if (hit.collider.CompareTag("MasaoDoor")) Inventory.GetComponent<CatDoorHandler>().doorMasao();
                else if (hit.collider.CompareTag("BathroomDoor")) Inventory.GetComponent<CatDoorHandler>().doorBathroom();
            }
        }
        else
        {
            doorIcon.enabled = false;
            doorText.enabled = false;
            if (CrosshairBool && !interactIcon.enabled && !npcIcon.enabled) crosshair.enabled = true;
        }

        // Shoots a ray
        if (Physics.Raycast(ray, out hit, interactDistance, npcLayer))
        {
            // check if we are interacting
            npcIcon.enabled = true;
            npcText.enabled = true;
            if (CrosshairBool) crosshair.enabled = false;

            if (hit.collider.CompareTag("Tatsumi")) tatsuminame.GetComponent<TextMesh>().color = Color.yellow;
            if (hit.collider.CompareTag("Rinni")) rinniname.GetComponent<TextMesh>().color = Color.yellow;
            if (hit.collider.CompareTag("Yuna")) yunaname.GetComponent<TextMesh>().color = Color.yellow;
            if (hit.collider.CompareTag("Masao")) masaoname.GetComponent<TextMesh>().color = Color.yellow;
            if (hit.collider.CompareTag("Rabbit")) rabbitname.GetComponent<TextMesh>().color = Color.yellow;

            // if we click the interact button
            if (Input.GetButtonDown(interactButton) && player.GetComponent<exitFungus>().enabled && !tempDisable) // Temporary disable for 4 seconds by snorlax
            {
                if (hit.collider.CompareTag("Tatsumi"))
                {
                    tatsuminame.GetComponent<TextMesh>().color = Color.yellow;
                    hit.collider.GetComponent<TatsumiC>().talkT();
                }
                else if (hit.collider.CompareTag("Rinni"))
                {
                    rinniname.GetComponent<TextMesh>().color = Color.yellow;
                    hit.collider.GetComponent<RinniCon>().talkR();
                }
                else if (hit.collider.CompareTag("Yuna"))
                {
                    yunaname.GetComponent<TextMesh>().color = Color.yellow;
                    hit.collider.GetComponent<yunaCon>().talkY();
                }
                else if (hit.collider.CompareTag("Masao"))
                {
                    masaoname.GetComponent<TextMesh>().color = Color.yellow;
                    hit.collider.GetComponent<masaoC>().talkM();
                }
                else if (hit.collider.CompareTag("Rabbit"))
                {
                    rabbitname.GetComponent<TextMesh>().color = Color.yellow;
                    Inventory.GetComponent<CatDoorHandler>().talkCat();
                }
            }
        }
        else
        {
            npcIcon.enabled = false;
            npcText.enabled = false;
            if (CrosshairBool && !doorIcon.enabled && !interactIcon.enabled) crosshair.enabled = true;
            tatsuminame.GetComponent<TextMesh>().color = Color.white;
            rinniname.GetComponent<TextMesh>().color = Color.white;
            yunaname.GetComponent<TextMesh>().color = Color.white;
            masaoname.GetComponent<TextMesh>().color = Color.white;
            rabbitname.GetComponent<TextMesh>().color = Color.white;
        }

        // Shoots a ray
        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            // check if we are interacting
            interactIcon.enabled = true;
            interactText.enabled = true;
            if (CrosshairBool) crosshair.enabled = false;

            // if we click the interact button
            if (Input.GetButtonDown(interactButton) && player.GetComponent<exitFungus>().enabled && !tempDisable) // Temporary disable for 4 seconds by snorlax
            {
                if (hit.collider.CompareTag("Clue")) hit.collider.GetComponent<Clue>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue2")) hit.collider.GetComponent<Clue2>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue3")) hit.collider.GetComponent<Clue3>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue4")) hit.collider.GetComponent<Clue4>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue5")) hit.collider.GetComponent<Clue5>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue6")) hit.collider.GetComponent<Clue6>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue7")) hit.collider.GetComponent<Clue7>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue8")) hit.collider.GetComponent<Clue8>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue9")) hit.collider.GetComponent<Clue9>().ShowNoteImage();
                else if (hit.collider.CompareTag("Clue10")) hit.collider.GetComponent<Clue10>().ShowNoteImage();

                else if (hit.collider.CompareTag("Safe1")) hit.collider.GetComponent<Safe1code>().ShowsafeImage();
                else if (hit.collider.CompareTag("Safe2")) hit.collider.GetComponent<Safe2code>().ShowsafeImage();
                else if (hit.collider.CompareTag("Puzzle")) hit.collider.GetComponent<Puzzle3D>().ShowPuzzleImage();
                else if (hit.collider.CompareTag("Enitio")) Inventory.GetComponent<Inventory>().Enitio(hit.collider.gameObject);

                else if (hit.collider.CompareTag("Dummy")) Dummy.GetComponent<Dummy>().ShowNoteImage();
                else if (hit.collider.CompareTag("Dummy2")) Dummy.GetComponent<Dummy>().ShowNoteImage2();
                else if (hit.collider.CompareTag("Dummy3")) Dummy.GetComponent<Dummy>().ShowNoteImage3();
                else if (hit.collider.CompareTag("Dummy4")) Dummy.GetComponent<Dummy>().ShowNoteImage4();
                else if (hit.collider.CompareTag("Dummy5")) Dummy.GetComponent<Dummy>().ShowNoteImage5();
                else if (hit.collider.CompareTag("Dummy6")) Dummy.GetComponent<Dummy>().ShowNoteImage6();
                else if (hit.collider.CompareTag("Dummy7")) Dummy.GetComponent<Dummy>().ShowNoteImage7();
                else if (hit.collider.CompareTag("Dummy8")) Dummy.GetComponent<Dummy>().ShowNoteImage8();
                else if (hit.collider.CompareTag("Dummy9")) Dummy.GetComponent<Dummy>().ShowNoteImage9();
                else if (hit.collider.CompareTag("Dummy10")) Dummy.GetComponent<Dummy>().ShowNoteImage10();
                else if (hit.collider.CompareTag("Dummy11")) Dummy.GetComponent<Dummy>().ShowNoteImage11();
                else if (hit.collider.CompareTag("Dummy12")) Dummy.GetComponent<Dummy>().ShowNoteImage12();
            }  
        }
        else
        {
            interactIcon.enabled = false;
            interactText.enabled = false;
            if (CrosshairBool && !doorIcon.enabled && !npcIcon.enabled) crosshair.enabled = true;
        }

        if (Physics.Raycast(ray, out hit, interactDistance, ignoreLayer)) Debug.Log("I'm a wall!");
    }

    public void doorOpen()
    {
        door = true;
        new WaitForSeconds(1);
    }
}
