using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Beam"))
        {
            // Destroy the beam
            Destroy(other.gameObject);
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
