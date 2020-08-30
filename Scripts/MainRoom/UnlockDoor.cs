//Make an empty GameObject and call it "Door"
//Drag and drop your Door model into Scene and rename it to "Body"
//Make sure that the "Door" Object is at the side of the "Body" object (The place where a Door Hinge should be)
//Move the "Body" Object inside "Door"
//Add a Collider (preferably SphereCollider) to "Door" object and make it much bigger then the "Body" model, mark it as Trigger
//Assign this script to a "Door" Object (the one with a Trigger Collider)
//Make sure the main Character is tagged "Player"
//Upon walking into trigger area, if 'key' is present, press "E" to open / close the door

using UnityEngine;

public class UnlockDoor : MonoBehaviour
{

    // Smoothly open a door
    public float doorOpenAngle = 90.0f; //Set either positive or negative number to open the door inwards or outwards
    public float openSpeed = 2.0f; //Increasing this value will make the door open faster
    public GameObject Inv;

    bool open = false;
    bool enter = false;
    bool keyget=false;

    float defaultRotationAngle;
    float currentRotationAngle;
    float openTime = 0;

    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.y;
        currentRotationAngle = transform.localEulerAngles.y;
    }

    // Main function
    void Update()
    {
        if (openTime < 1)
        {
            openTime += Time.deltaTime * openSpeed;
        }
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Mathf.LerpAngle(currentRotationAngle, defaultRotationAngle + (open ? doorOpenAngle : 0), openTime), transform.localEulerAngles.z);

        if (Input.GetKeyDown(KeyCode.E) && enter)
        {
            open = true;
            currentRotationAngle = transform.localEulerAngles.y;
            openTime = 0;
            Inv.GetComponent<Inventory>().disClue9();
        }
    }

    // Display a simple info message when player is inside the trigger area
    void OnGUI()
    {
        if (enter/* && lockedstate == false*/) //door is unlocked
        {
            GUI.skin.label.fontSize = 30;
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height - 100, 500, 40), "Press [E] to open the door");
        }
        if (/*lockedstate && */enter)
        {
            GUI.skin.label.fontSize = 30;
            GUI.Label(new Rect(Screen.width / 2 - 110, Screen.height - 100, 500, 40), "The door is locked.");
        }

    }

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }

    }

    // Deactivate the Main function when Player exit the trigger area
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;
        }
    }

    public void keyg()
    {
        keyget = true;
    }
}