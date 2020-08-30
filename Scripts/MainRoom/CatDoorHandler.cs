//Make an empty GameObject and call it "Door"
//Drag and drop your Door model into Scene and rename it to "Body"
//Make sure that the "Door" Object is at the side of the "Body" object (The place where a Door Hinge should be)
//Move the "Body" Object inside "Door"
//Add a Collider (preferably SphereCollider) to "Door" object and make it much bigger then the "Body" model, mark it as Trigger
//Assign this script to a "Door" Object (the one with a Trigger Collider)
//Make sure the main Character is tagged "Player"
//Upon walking into trigger area press "E" to open / close the door

using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDoorHandler : MonoBehaviour
{
    // Smoothly open a door
    public float doorOpenAngle = -90.0f; //Set either positive or negative number to open the door inwards or outwards
    public float openSpeed = 2.0f; //Increasing this value will make the door open faster

    public GameObject Inventory;
    public GameObject YunaDoor;
    public GameObject MasaoDoor;
    public GameObject BathroomDoor;
    public GameObject YunaBlocker;
    public GameObject MasaoBlocker;

    public GameObject locked;
    public GameObject y1;
    public GameObject m1;
    public GameObject m2;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;

    public bool key9got = false;
    private bool openYuna = false;
    private bool openMasao = false;
    private bool openBathroom = false;

    //bool enter = false;
    float defaultRotationAngleY;
    float currentRotationAngleY;
    float defaultRotationAngleM;
    float currentRotationAngleM;
    float defaultRotationAngleB;
    float currentRotationAngleB;
    float openTimeY = 0;
    float openTimeM = 0;
    float openTimeB = 0;

    private bool yunatalked = false;
    private bool rabbitfed = false;
    public GameObject Clue7Obj;
    public GameObject rabbitname;
    public GameObject Rabbit;

    private Animator m_animator;
    private bool rRotate = false;
    private bool rRotate2 = false;
    private bool rTranslate = false;
    private float rRotationAngley;
    private float rPositionx;
    private float rPositionz;
    private bool runOnce = false;

    void Start()
    {
        defaultRotationAngleY = YunaDoor.transform.localEulerAngles.y;
        currentRotationAngleY = YunaDoor.transform.localEulerAngles.y;
        defaultRotationAngleM = MasaoDoor.transform.localEulerAngles.y;
        currentRotationAngleM = MasaoDoor.transform.localEulerAngles.y;
        defaultRotationAngleB = BathroomDoor.transform.localEulerAngles.y;
        currentRotationAngleB = BathroomDoor.transform.localEulerAngles.y;
        m_animator = Rabbit.GetComponent<Animator>();
        rRotationAngley = Rabbit.transform.localEulerAngles.y;
        rPositionx = Rabbit.transform.position.x;
        rPositionz = Rabbit.transform.position.z;
    }

    // Main function
    void Update()
    {
        if (openTimeY < 1) openTimeY += Time.deltaTime * openSpeed;
        YunaDoor.transform.localEulerAngles = new Vector3(YunaDoor.transform.localEulerAngles.x,
                                                          Mathf.LerpAngle(currentRotationAngleY, defaultRotationAngleY + (openYuna ? doorOpenAngle : 0), openTimeY),
                                                          YunaDoor.transform.localEulerAngles.z);
        if (openTimeM < 1) openTimeM += Time.deltaTime * openSpeed;
        MasaoDoor.transform.localEulerAngles = new Vector3(MasaoDoor.transform.localEulerAngles.x,
                                                           Mathf.LerpAngle(currentRotationAngleM, defaultRotationAngleM + (openMasao ? doorOpenAngle : 0), openTimeM),
                                                           MasaoDoor.transform.localEulerAngles.z);
        if (openTimeB < 1) openTimeB += Time.deltaTime * openSpeed;
        BathroomDoor.transform.localEulerAngles = new Vector3(BathroomDoor.transform.localEulerAngles.x,
                                                              Mathf.LerpAngle(currentRotationAngleB, defaultRotationAngleB + (openBathroom ? doorOpenAngle : 0), openTimeB),
                                                              BathroomDoor.transform.localEulerAngles.z);

        // Rabbit animation
        if (runOnce)
        {
            if (rRotate)
            {
                m_animator.SetBool("Walk", true);
                rRotationAngley -= Time.deltaTime * 60;
                Rabbit.transform.localEulerAngles = new Vector3(0, rRotationAngley, 0);
                if (rRotationAngley < 90)
                {
                    rRotate = false;
                    rTranslate = true;
                }
            }
            if (rTranslate)
            {
                rPositionx += Time.deltaTime * 0.4f;
                rPositionz -= Time.deltaTime * 0.02f;
                Rabbit.transform.position = new Vector3(rPositionx, Rabbit.transform.position.y, rPositionz);
                if (rPositionx > 97)
                {
                    Clue7Obj.SetActive(true);
                    rTranslate = false;
                    rRotate2 = true;
                    m_animator.SetBool("Sit", true);
                    m_animator.SetBool("Walk", false);
                }
                /*
                if (rPositionx > 97) Clue7Obj.SetActive(true);
                if (rPositionx > 97.85)
                {
                    rTranslate = false;
                    rRotate2 = true;
                    m_animator.SetBool("Sit", true);
                    m_animator.SetBool("Walk", false);
                }
                */
            }
            if (rRotate2)
            {
                rRotationAngley += Time.deltaTime * 60;
                Rabbit.transform.localEulerAngles = new Vector3(0, rRotationAngley, 0);
                if (rRotationAngley > 225)
                {
                    rRotate2 = false;
                    runOnce = false;
                }
            }
        }
    }

    public void talkCat()
    {
        if (!yunatalked)
        {
            c1.SetActive(false);
            c1.SetActive(true);
        }
        else if (!c2.activeSelf)
        {
            c2.SetActive(true);
        }
        else if (rabbitfed)
        {
            c4.SetActive(false);
            c4.SetActive(true);
        }
        else
        {
            c3.SetActive(false);
            c3.SetActive(true);
        }
    }

    public void doorLocked()
    {
        locked.SetActive(false);
        locked.SetActive(true);
    }

    public void doorYuna()
    { 
        y1.SetActive(false);
        y1.SetActive(true);
    }

    public void doorMasao()
    {
        if (key9got)
        {
            m1.SetActive(false);
            m1.SetActive(true);
        }
        else
        {
            m2.SetActive(false);
            m2.SetActive(true);
        }
    }
    
    public void doorBathroom()
    {
        BathroomDoor.layer = 0;
        openBathroom = true;
        openTimeB = 0;
    }

    // Scripts below run from fungus

    public void OpenDoorYuna()
    {
        YunaDoor.layer = 0;
        openYuna = true;
        openTimeY = 0;
        Inventory.GetComponent<Inventory>().disClue4();
        Destroy(YunaBlocker);
    }

    public void OpenDoorMasao()
    {
        MasaoDoor.layer = 0;
        openMasao = true;
        openTimeM = 0;
        Inventory.GetComponent<Inventory>().disClue9();
        Destroy(MasaoBlocker);
    }

    public void YunaTalked()
    {
        yunatalked = true;
    }

    public void ShowRabbitLabel()
    {
        rabbitname.SetActive(true);
    }

    public void RabbitFed()
    {
        rabbitfed = true;
        rRotate = true;
        runOnce = true;
        Inventory.GetComponent<Inventory>().disClue0();
    }
}