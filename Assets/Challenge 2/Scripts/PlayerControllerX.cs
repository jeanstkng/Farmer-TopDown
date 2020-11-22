using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField, Range(0.1f, 5.0f)]
    private float minWaitTime = 1.0f;
    [SerializeField, Range(0.1f, 10.0f)]
    private float maxWaitTime = 1.0f;

    private float counter = 0;
    private float nextWaitTime = 1f;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

        counter += Time.deltaTime;
        if (counter >= nextWaitTime)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                counter = 0;
                nextWaitTime = Random.Range(minWaitTime, maxWaitTime);
            }
        }


    }

}
