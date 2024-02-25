using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    // Called when another collider enters the trigger
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding GameObject has a specific tag (you can replace "Player" with any other tag you want)
        if (collision.gameObject.CompareTag("Player"))
        {
            // Hide or destroy the GameObject
            gameObject.SetActive(false); // This will deactivate the GameObject
            // Destroy(gameObject); // Uncomment this line if you want to destroy the GameObject instead
        }
    }
}