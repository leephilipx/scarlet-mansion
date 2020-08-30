using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource BlipSound;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        this.GetComponent<Text>().color = Color.red;
        BlipSound.Play(0);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        this.GetComponent<Text>().color = Color.white;
    }
}
