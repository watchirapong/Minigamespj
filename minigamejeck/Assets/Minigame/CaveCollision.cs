using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveCollision : MonoBehaviour
{
    // URL to open when the player collides with the cave
    public string caveURL = "https://wcpheal.itch.io/minigamehamster-town";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is tagged as "Player"
        if (collision.CompareTag("player"))
        {
            Application.OpenURL(caveURL);
        }
    }
}
