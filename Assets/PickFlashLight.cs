using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFlashLight : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject flashlight,intText,destroyfl;
    private bool hasfl = false;
    private Light flashlightLight;


    void Start()
    {
        flashlightLight = flashlight.GetComponent<Light>();
        if (flashlightLight != null)
        {
            flashlightLight.enabled = false; // Ensure the flashlight is off initially
        }
    }

    void Update()
    {
        if (hasfl && Input.GetKeyDown(KeyCode.F))
        {
            flashlightLight.enabled = !flashlightLight.enabled;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
            intText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                flashlight.SetActive(true);
                hasfl = true;
                if(flashlightLight != null)
                {
                    flashlightLight.enabled = true;
                }
                Destroy(destroyfl);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FlashLight"))
        {
            intText.SetActive(false);
        }
    }
}
