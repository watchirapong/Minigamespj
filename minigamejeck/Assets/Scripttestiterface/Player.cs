using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject _cubeObject;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check if left mouse button is clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the mouse position
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // Cast the ray and check if it hits something
            {
                //ตัวอย่างที่ดี 
                var interactable = hit.collider.GetComponent<IInteractable>(); // Get the IInteractable component from the object hi
                Debug.Log(interactable);
                if (interactable != null)
                {
                    interactable.Interact();
                    interactable.Clickcount(1);
                }

                /* ตัวอย่างที่ม่ายดีย์
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.name == "Cube")
                {
                    GameObject _cubeObject = hitObject;
                    Debug.Log("Hit a cube");
                }
                else if (hitObject.name == "Sphere")
                {
                    GameObject _SphereObject = hitObject;
                    Debug.Log("Hit a Sphere");
                }
                else if (hitObject.name == "Capsule")
                {
                    GameObject _CapsuleObject = hitObject;
                    Debug.Log("Hit a Capsule");
                }
                */
            }
        }
    }
}

