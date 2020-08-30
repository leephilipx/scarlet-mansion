using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TatsumiC : MonoBehaviour
{
    public GameObject player;
    public bool playerEntered;
    public GameObject tatsuminame;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public GameObject c7;
    public bool picked;
    
    public GameObject eImage;
    public GameObject eText;
    
    public bool done;
    private bool t3ran = false;
    private bool c7taken = false;



    // Update is called once per frame
    public void talkT()
    {
        tatsuminame.GetComponent<TextMesh>().color = Color.yellow;

        if (!t1.activeSelf)
        {
            t1.SetActive(true);
        }
        else
        { 
            if (picked)
            {
                if (done && t3ran && c7taken)
                {
                    t5.SetActive(false);
                    t5.SetActive(true);
                }
                else if (t3ran && c7taken)
                {
                    t4.SetActive(false);
                    t4.SetActive(true);
                }
                else
                {
                    t3.SetActive(false);
                    t3.SetActive(true);
                    t3ran = true;
                }

            }
            else
            {
                t2.SetActive(false);
                t2.SetActive(true);
            }
        }
    }

    /*
    [System.Obsolete]
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
            tatsuminame.GetComponent<TextMesh>().color = Color.white;
        }
    }
    */

    public void C7Taken()
    {
        c7taken = true;
    }
}
