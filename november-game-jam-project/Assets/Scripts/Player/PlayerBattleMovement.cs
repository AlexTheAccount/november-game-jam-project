using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBattleMovement : MonoBehaviour
{
    [Header("Dash Settings")]
    [SerializeField] private float DashSpeed = 20f;
    [SerializeField] private float DashDuration = 0.2f;

    private bool isDashing = false;
    private Rigidbody2D rigidbody;

    [Header("Move Settings")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float sprintMultiplier = 2f;

    private Vector2 moveInput;
    private bool sprinting;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDashing) return;

        // Handle dash input
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            print("Dash initiated");
            StartCoroutine(Dash());
        }
    }

    private System.Collections.IEnumerator Dash()
    {
        isDashing = true;
        yield return new WaitForSeconds(DashDuration);
        isDashing = false;
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

        if (isDashing)
            currentSpeed = DashSpeed;

        Vector2 movement = moveInput.normalized;

        rigidbody.linearVelocity = movement * currentSpeed;
    }
}
