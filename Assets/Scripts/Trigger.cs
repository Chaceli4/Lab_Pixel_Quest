using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDetector : MonoBehaviour
{
    private Collider detectionArea;  // The area you want to detect movement within


    void OnTriggerEnter(Collider other)
    {
        // When an object enters the detection area
        if (other.CompareTag("MovableObject"))
        {
            Debug.Log($"{other.name} entered the detection area.");
        }
    }

    void OnTriggerStay(Collider other)
    {
        // When an object stays within the detection area
        if (other.CompareTag("MovableObject"))
        {
            Debug.Log($"{other.name} is staying in the detection area.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // When an object exits the detection area
        if (other.CompareTag("MovableObject"))
        {
            Debug.Log($"{other.name} left the detection area.");
        }
    }
}