using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class coinw : MonoBehaviour
{
    public GameObject objectToActivate;
    public List<GameObject> objectsToTouch = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
             objectsToTouch.Remove(other.gameObject);

            if (objectsToTouch.Count == 0)
            {
                objectToActivate.SetActive(false);
            }
        }
    }
}