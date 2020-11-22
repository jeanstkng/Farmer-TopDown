using UnityEngine;

public class SpawnManagerX : MonoBehaviour {
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private int ballsLen;
    private float counter = 0f;
    private float nextWaitTime = 5f;

    [SerializeField, Range(1.0f, 5.0f)]
    private float minWaitTime = 2.0f;
    [SerializeField, Range(5.0f, 10.0f)]
    private float maxWaitTime = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        ballsLen = ballPrefabs.Length - 1;
    }

    private void Update()
    {
        counter += Time.deltaTime;
        if (counter >= nextWaitTime)
        {
            SpawnRandomBall();
            Debug.LogFormat("We've waited {0} seconds", nextWaitTime);
            counter = 0;
            nextWaitTime = Random.Range(minWaitTime, maxWaitTime);
        }
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBallIdx = Random.Range(0, ballsLen);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallIdx], spawnPos, ballPrefabs[randomBallIdx].transform.rotation);
    }

}
