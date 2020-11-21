using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;

    public float xRange = 15.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Character Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        CheckInBounds(1);
        CheckInBounds(-1);

        // Character Actions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If we enter here, a projectile should be shoot.
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }

    public void CheckInBounds(int sign)
    {
        if ((transform.position.x > sign * xRange && sign > 0) || (transform.position.x < sign * xRange && sign < 0))
        {
            transform.position = new Vector3(sign * xRange, transform.position.y, transform.position.z);
        }
    }
}
