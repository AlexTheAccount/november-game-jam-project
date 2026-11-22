using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Move Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sprintMultiplier = 2f;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool sprinting;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnSprint(InputValue value)
    {
        sprinting = value.isPressed;
    }

    private void FixedUpdate()
    {
        float currentSpeed = moveSpeed;

        if (sprinting)
            currentSpeed *= sprintMultiplier;

        Vector2 movement = moveInput.normalized;

        rb.linearVelocity = movement * currentSpeed;
    }
}
