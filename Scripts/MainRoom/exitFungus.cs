using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class exitFungus : MonoBehaviour
{
    public GameObject characterController; //the character controller to disable/enable
    public GameObject tatsumi;
    public GameObject rinni;
    public GameObject yuna;
    public GameObject masao;
    public GameObject npcIcon;
    public bool RunOnceCH;
    public Image Crosshair;
    public bool CrosshairBool = false;
    /*
    public GameObject eImage;
    public GameObject eText;
    */

    // Update is called once per frame
    void Update()
    {
        Debug.Log​("Cursor locked");
        characterController.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        npcIcon.SetActive(true);
        /*
        if (tatsumi.GetComponent<TatsumiC>().playerEntered|| rinni.GetComponent<RinniCon>().playerEntered || yuna.GetComponent<yunaCon>().playerEntered || masao.GetComponent<masaoC>().playerEntered)
        {
            eImage.SetActive(true);
            eText.SetActive(true);
        }
        else
        {
            eImage.SetActive(false);
            eText.SetActive(false);
        }
        */
        if (RunOnceCH && CrosshairBool)
        {
            RunOnceCH = false;
            Crosshair.enabled = true;
        }
    }
}
