using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float speed = 5f;          // forward speed
    public float floatHeight = 1f;    // how high it floats
    public float floatSpeed = 2f;     // speed of floating

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Float up and down
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}