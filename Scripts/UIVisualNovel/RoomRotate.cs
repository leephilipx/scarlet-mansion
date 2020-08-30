using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRotate : MonoBehaviour
{
    public float RotationsPerMinute = 3.0f;
    public Vector3 target = new Vector3(2.0f, 2.0f, -1.5f);
    public Texture2D cursorArrow;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorArrow, new Vector2(16, 16), CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target, Vector3.up, 6.0f * RotationsPerMinute * Time.deltaTime);
        Debug.Log(Time.deltaTime);
    }
}
