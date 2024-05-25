using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCapsule : MonoBehaviour, IInteractable
{
    public int counter;
    public void Interact()
    {
        Debug.Log("Interact on Capsule");
    }
    public void Clickcount(int count)
    {
        counter += count;
        Debug.Log("Capsule count :"+ counter);
    }

}
