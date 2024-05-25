using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballinteract : MonoBehaviour, IInteractbals
{
    public void warp(Transform target, GameObject player, GameObject deadbody, GameObject specialfx, float delay)
    {
        Instantiate(specialfx, player.transform.position, Quaternion.identity);
        Instantiate(deadbody, player.transform.position, Quaternion.identity);
        // player.transform.position = target.position;
        player.SetActive(false);
        StartCoroutine(ExitGameAfterDelay(delay));
        IEnumerator ExitGameAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            Debug.Log("Exitgame");

            // Exit the game
            // Application.Quit();
            player.transform.position = target.position;
            player.SetActive(true);
        }
    }
}
