using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUP : MonoBehaviour
{
    public GameObject infoPlane; // The plane to display information
    public GameObject intText; // The text to display interaction prompt

    private bool isPanelActive = false; // To track the panel state

    void Update()
    {
        // Check for the Escape key press to close the panel and resume the game
        if (isPanelActive && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePanel();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            intText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Time.timeScale = 0;
                infoPlane.SetActive(true);
                intText.SetActive(false);
                isPanelActive = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            intText.SetActive(false);
        }
    }

    void ClosePanel()
    {
        // Deactivate the information panel
        infoPlane.SetActive(false);
        isPanelActive = false;

        // Resume the game
        Time.timeScale = 1;
    }

}










