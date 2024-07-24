using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickMaterials : MonoBehaviour
{
    public GameObject collectTextObj, intText;
    public bool interactable;
    public static int matsCollected;
    public TextMeshProUGUI collectText;



    void Start()
    {
        matsCollected = 0;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                matsCollected = matsCollected + 1;
                collectText.text = matsCollected + "/3 materials collected";
                collectTextObj.SetActive(true);          
                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }
    }
}
