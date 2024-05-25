using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractbals
{
    void warp(Transform target,GameObject player,GameObject deadbody,GameObject specialfx,float delay);
    // IEnumerator ExitGameAfterDelay(float delay)
    //     {
    //         yield return new WaitForSeconds(delay);
    //         Debug.Log("Exitgame");

    //         // Exit the game
    //         // Application.Quit();
    //         player.transform.position = target.position;
    //         player.SetActive(true);
    //     }

}
