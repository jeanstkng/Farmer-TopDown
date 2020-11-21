using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    // OnTriggerEnter will be called automatically when
    // a fisic object enters inside the trigger of the GameObject
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // The animal touchs a projectile
            Destroy(this.gameObject); // Destroys the animal
            Destroy(other.gameObject); // Destroys the other
        }

    }
}
