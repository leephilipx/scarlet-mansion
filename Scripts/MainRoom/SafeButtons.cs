using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeButtons : MonoBehaviour
{
    public Text safeDisplay;
    string a;
    int count = 0;
    public Safe2code sf2;
    public Safe2 s2;

    private void Start()
    {
        count = 0;
        a = "";
    }
    void Update()
    {
        if (count == 4)
        {
            if (a == "5739")
            {
                sf2.openSafe();
                Debug.Log("Open Safe");
                a = "";
                safeDisplay.text = a;
                s2.sol();
                count = 0;
            }
            else
            {
                safeDisplay.text = "Wrong";
                a = "";
                count = 0;
            }
        }
    }

    public void button1()
    {
        a += '1' ;
        safeDisplay.text = a;
        count++;
        Debug.Log("hi");
    }
    public void button2()
    {
        a += '2' ;
        safeDisplay.text = a;
        count++;
    }
    public void button3()
    {
        a += '3';
        safeDisplay.text = a;
        count++;
    }
    public void button4()
    {
        count++;
        a += '4';
        safeDisplay.text = a;
    }
    public void button5()
    {
        count++;
        a += '5';
        safeDisplay.text = a;
    }
    public void button6()
    {
        count++;
        a += '6';
        safeDisplay.text = a;
    }
    public void button7()
    {
        count++;
        a += '7';
        safeDisplay.text = a;
    }
    public void button8()
    {
        count++;
        a += '8';
        safeDisplay.text = a;
    }
    public void button9()
    {
        count++;
        a += '9';
        safeDisplay.text = a;
    }
    public void button0()
    {
        count++;
        a += '0';
        safeDisplay.text = a;
    }
    public void buttonClear()
    {
        count = 0;
        a = "";
        safeDisplay.text = a;
    }    
}

