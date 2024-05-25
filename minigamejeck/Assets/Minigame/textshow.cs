using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textshow : MonoBehaviour
{
    public GameObject textObject; // Reference to the Text component


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Textshow"))
        {
            textObject.SetActive(true);
            Debug.Log("Player entered trigger");
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Textshow"))
        {
            // Deactivate the text object
            textObject.SetActive(false);
            Debug.Log("Player exited trigger");
        }
    }
}

