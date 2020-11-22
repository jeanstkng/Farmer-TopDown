using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private int gameOverCount = 0;
    public int gameOverLimit = 5;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Ball"))
        {
            gameOverCount += 1;
            Debug.Log(gameOverCount);
            if (gameOverCount >= gameOverLimit)
            {
                Time.timeScale = 0;
                Debug.Log("Game Over");
            }
        }
    }
}
