using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitgame : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public GameObject specialFXPrefab; // Reference to the special effect prefab
    public float delayBeforeExit = 3f; // Delay before exiting the game
    public GameObject  textshowendgame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Player entered trigger");

            // Destroy the player GameObject
            Destroy(player);

            // Instantiate special effect at player's position
            Instantiate(specialFXPrefab, player.transform.position, Quaternion.identity);
            

            // Call method to exit the game after delay
            StartCoroutine(ExitGameAfterDelay(delayBeforeExit));
        }
    }

    IEnumerator ExitGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Exitgame");

        // Exit the game
        #if UNITY_EDITOR
            // If running in the Unity Editor, stop playing
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // If running in a build, quit the application
            Application.Quit();
        #endif
    }
}
