using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButtons : MonoBehaviour
{
    public GameObject cS;
    public GameObject cMM;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && cS.activeSelf)
        {
            cMM.SetActive(true);
            cS.SetActive(false);
        }
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void OnSettings()
    {
        cS.SetActive(true);
        cMM.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnBack()
    {
        cMM.SetActive(true);
        cS.SetActive(false);
    }
}
