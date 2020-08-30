using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yunaCon : MonoBehaviour
{
    public GameObject player;
    public bool playerEntered;
    public GameObject yunaname;
    public GameObject y2a;
    public GameObject y2b;
    public GameObject y4a;
    public GameObject y4b;
    public GameObject eImage;
    public GameObject eText;
    
    public bool vA = false;
    public bool screamconvo = false;

    // Update is called once per frame
    public void talkY()
    {
        yunaname.GetComponent<TextMesh>().color = Color.yellow;

        /*if (vA)
        {
            if (!y1.activeSelf)
            {
                y2.SetActive(false);
                y2.SetActive(true);
            }
            else
            {
                y3.SetActive(false);
                y3.SetActive(true);
            }
        }
        else
        {
            y1.SetActive(false);
            y1.SetActive(true);
        }*/

        if (!vA)
        {
            if (!y2a.activeSelf && !screamconvo)
            {
                y2a.SetActive(true);
                screamconvo = true;
            }
            else
            {
                y2b.SetActive(false);
                y2b.SetActive(true);
            }
        }
        else
        {
            if (!y4a.activeSelf && !screamconvo)
            {
                y4a.SetActive(true);
                screamconvo = true;
            }
            else
            {
                y4b.SetActive(false);
                y4b.SetActive(true);
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
            yunaname.GetComponent<TextMesh>().color = Color.white;
        }
    }
    */
}
