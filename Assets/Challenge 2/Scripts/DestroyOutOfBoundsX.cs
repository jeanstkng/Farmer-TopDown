using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f;
    private float bottomLimit = -1f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (this.transform.position.x < leftLimit)
        {
            Destroy(this.gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (this.transform.position.y < bottomLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
