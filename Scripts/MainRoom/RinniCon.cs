using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinniCon : MonoBehaviour
{
    public GameObject player;
    public bool playerEntered;
    private bool umbReturned=false;
    public GameObject rinniname;
    public GameObject rin1;
    public GameObject rin2;
    public GameObject rin3;
    public GameObject rin3b;
    public GameObject rin4;
    public bool picked;
    public bool talked;
    public bool flight;

    public GameObject eImage;
    public GameObject eText;
    

    // Update is called once per frame
    public void talkR()
    {
        rinniname.GetComponent<TextMesh>().color = Color.yellow;

        if (!rin1.activeSelf)
        {
            rin1.SetActive(true);
            talked = true;
        }
        else
        {
            if (flight)
            {
                rin4.SetActive(false);
                rin4.SetActive(true);
            }
            else if (!picked)
            {
                rin2.SetActive(false);
                rin2.SetActive(true);
            }
            else if (umbReturned)
            {
                rin3b.SetActive(false);
                rin3b.SetActive(true);
            }
            else
            {
                rin3.SetActive(true);
                umbReturned = true;
            }
        }
    }

    /*
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
            //hide interact message as player may not have been looking at object when they left
            Debug.Log("Exit");
        }
    }
    */
}
