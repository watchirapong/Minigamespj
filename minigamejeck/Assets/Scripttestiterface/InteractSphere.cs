using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSphere : MonoBehaviour, IInteractable
{
    public int counter;
    public void Interact()
    {
        Debug.Log("Interact On Sphere");
    }
    public void Clickcount(int count)
    {
        counter += count;
        Debug.Log("Cube count :"+ counter);
    }
}
