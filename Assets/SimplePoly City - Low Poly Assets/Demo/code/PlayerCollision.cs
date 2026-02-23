using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            transform.position = respawnPoint.position;

            Console.WriteLine("Player has collided with a car and respawned.");


        }
    }
}
