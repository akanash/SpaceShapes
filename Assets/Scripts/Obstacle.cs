using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;

    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    public float minSize = 0.5f;
    public float maxSize = 2.0f;


    public float maxSpinSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
    

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
        rb.mass *= randomSize; // Adjust mass based on size for more realistic physics


        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
