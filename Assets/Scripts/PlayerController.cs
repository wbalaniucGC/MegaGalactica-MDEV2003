using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector2 moveValue;

    private void Awake()
    {
        // Set up references
        moveValue = Vector2.zero;
    }

    private void Update()
    {
        // Yes you can put your movement code in here. But why shouldn't you?
        // The name of the function does not describe what the code is doing.
        Move();
    }

    // Public function that I can use to respond to Input Actions
    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveValue = ctx.ReadValue<Vector2>();
    }

    private void Move()
    {
        transform.Translate(new Vector3(moveValue.x, moveValue.y, 0) * speed * Time.deltaTime);
    }
}
