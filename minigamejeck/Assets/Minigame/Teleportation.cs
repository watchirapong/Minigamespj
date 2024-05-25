using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject Player;
    public Transform teleportTarget; // The target location where the player will be teleported
    public float delayfordeath = 3f;
    public GameObject specialFXPrefab;
    public GameObject deadbody;

    void Start() 
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            // Instantiate(specialFXPrefab, Player.transform.position, Quaternion.identity);
            // Instantiate(deadbody, Player.transform.position, Quaternion.identity);
            // Player.transform.position = teleportTarget.position;
            var interactable = other.GetComponent<IInteractbals>();
            Debug.Log(interactable);
            if (interactable != null)
            {
                interactable.warp(teleportTarget, Player, deadbody,specialFXPrefab,delayfordeath);
            }
        }
        else if (other.gameObject.CompareTag("Checkpoint"))
        {
            teleportTarget = other.transform; // Update the teleport target to the checkpoint
        }
    }
}
