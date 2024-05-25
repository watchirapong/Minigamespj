using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class PlayerTouch : MonoBehaviour
{
    public List<GameObject> balls = new List<GameObject>();

    void Start()
    {
        // Find all objects with the tag "Ball" and add them to the list
        GameObject[] ballObjects = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject ball in ballObjects)
        {
            balls.Add(ball);
            Debug.Log("ballcheck");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            // Activate all objects with the tag "Ball"
            foreach (GameObject ball in balls)
            {
                ball.SetActive(true);
                Debug.Log("touchcheck");
            }
        }
    }
}
