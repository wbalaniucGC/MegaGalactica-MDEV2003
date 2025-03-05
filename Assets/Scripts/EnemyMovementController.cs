using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 3.0f;

    private bool reachedTarget = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!reachedTarget)
        {
            MoveToTarget();
        }
    }

    private void MoveToTarget()
    {
        // Move the enemy towards the target position
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        // Check if the enemy has reached the target poisiton
        if(Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            // Generate a new random target position
            reachedTarget = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Beam"))
        {
            // Destroy the enemy when it collides with the player
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
