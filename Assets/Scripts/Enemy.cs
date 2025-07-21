using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the Inspector
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Move towards the player's position
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}