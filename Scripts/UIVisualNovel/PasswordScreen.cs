using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasswordScreen : MonoBehaviour
{
    public string PasswordTitle = "password";
    public string PasswordMain = "betaloadmain";
    public InputField IInputField;
    public Text EnterPasswordText;
    public GameObject ScriptContainer;
    public int StartScene = 0;

    // Start is called before the first frame update
    void Start()
    {
        IInputField.Select();
        IInputField.ActivateInputField();
        // For developer use, load specific scene at start
        if (StartScene != 0) SceneManager.LoadScene(StartScene);
    }

    // Update is called once per frame
    void Update()
    {
        IInputField.Select();
        IInputField.ActivateInputField();
        if (Input.GetKey(KeyCode.Return))
        {
            if (IInputField.text != "")
            {
                if (IInputField.text == PasswordTitle)
                {
                    IInputField.text = "";
                    EnterPasswordText.text = "Correct password! Welcome USER!";
                    SceneManager.LoadScene(1);
                    ScriptContainer.GetComponent<PasswordScreen>().enabled = false;
                }
                else if (IInputField.text == PasswordMain)
                {
                    IInputField.text = "";
                    EnterPasswordText.text = "[Admin] Main scene loaded!";
                    SceneManager.LoadScene(3);
                    ScriptContainer.GetComponent<PasswordScreen>().enabled = false;
                }
                else
                {
                    EnterPasswordText.text = "Wrong password! Please try again:";
                }
                IInputField.text = "";
            }
        }
    }

    public void OnQuit()
    {
        Application.Quit();
    }    
}
