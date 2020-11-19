using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int animalIndex;

    private float spawnRangeX = 20f;
    private float spawnPositionZ = 28f;
    private int enemiesLen;

    [SerializeField, Range(0f, 10f)]
    private float startDelay = 2f;

    [SerializeField, Range(0.1f, 5f)]
    private float spawnInterval = 0.5f;

    private void Start() {
        spawnPositionZ = this.transform.position.z;
        enemiesLen = enemies.Length;
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }


    private void SpawnRandomEnemy()
    {
        float xRandom = Random.Range(-spawnRangeX, spawnRangeX);
        // Generate position where next enemy will spawn
        Vector3 spawnPos = new Vector3(xRandom, 0, spawnPositionZ);
        animalIndex = Random.Range(0, enemiesLen);
        Instantiate(enemies[animalIndex],
                spawnPos,
                enemies[animalIndex].transform.rotation);
    }
}
