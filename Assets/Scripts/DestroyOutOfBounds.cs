using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30f;
    private float bottomBound = -5f;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound || this.transform.position.z < bottomBound) {
            Destroy(this.gameObject);
        }
    }
}
