using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallTouchCounter : MonoBehaviour
{
    public Text touchCountText; // Reference to the Text component

    private int touchCount = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            touchCount++;
            UpdateTouchCountText();

        }
    }

    private void UpdateTouchCountText()
    {
        // Update the text to display the touch count
        if (touchCountText != null)
        {
            touchCountText.text = "DEATH : " + touchCount;
        }
    }
}
