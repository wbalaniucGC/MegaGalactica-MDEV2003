using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject beamPrefab; // Reference to the beam prefab
    public Transform beamSpawnPoint; // Reference to the beam spawn point

    private Vector2 moveInput;
    private void Update()
    {
        Move();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move: {moveInput}");
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(beamPrefab, beamSpawnPoint.position, beamSpawnPoint.rotation);
        }
    }

    private void Move()
    {
        Vector3 move = new Vector3(moveInput.x, moveInput.y, 0) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}
