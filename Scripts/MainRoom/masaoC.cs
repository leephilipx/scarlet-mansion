using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masaoC : MonoBehaviour
{
    public GameObject player;
    public bool playerEntered;
    public GameObject masaoname;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public bool vA;
    public bool flight;
    
    public GameObject eImage;
    public GameObject eText;
    

    // Update is called once per frame
    public void talkM()
    {
        if (vA && flight)
        {
            m3.SetActive(false);
            m3.SetActive(true);
        }
        else if (vA)
        {
            m2.SetActive(false);
            m2.SetActive(true);
        }
        else if (flight)
        {
            m4.SetActive(false);
            m4.SetActive(true);
        }
        else
        {
            m1.SetActive(false);
            m1.SetActive(true);
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
            masaoname.GetComponent<TextMesh>().color = Color.white;
        }
    }
    */
}
