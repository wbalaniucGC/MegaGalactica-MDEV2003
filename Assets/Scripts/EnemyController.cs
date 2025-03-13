using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int offsetToTarget = 5;
    public float speed = 3f;

    public GameObject explosionPrefab;

    private Vector3 targetPosition = Vector3.zero;
    private bool reachedTarget = false;

    private void Start()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y - offsetToTarget, transform.position.z);
    }

    private void Update()
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

        // Check if the enemy has reached the target position
        if(Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            reachedTarget = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Beam"))
        {
            // Destroy the beam
            Destroy(other.gameObject);
            // Create the explosion
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
