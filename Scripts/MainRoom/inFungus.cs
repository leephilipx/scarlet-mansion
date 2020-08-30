using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class inFungus : MonoBehaviour
{
    public GameObject characterController; //the character controller to disable/enable
    /*
    public GameObject eImage;
    public GameObject eText;
    */
    public GameObject npcIcon;
    public Image Crosshair;
    public bool CrosshairBool = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Cursor unlocked");
        characterController.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        npcIcon.SetActive(false);
        /*
        eImage.SetActive(false);
        eText.SetActive(false);
        */
        if (CrosshairBool)
        {
            Crosshair.enabled = false;
            characterController.GetComponent<exitFungus>().RunOnceCH = true;
        }
    }
}
