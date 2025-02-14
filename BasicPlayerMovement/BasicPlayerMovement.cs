using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player
    public float jumpForce = 5f; // Jump force for the player
    private Rigidbody rb; // Reference to the Rigidbody component
    private bool isGrounded; // Check if the player is grounded

    // You can assign this in the Unity editor
    public Transform groundCheck; // Position to check if the player is on the ground
    public LayerMask groundLayer; // Layer mask for the ground

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the player
    }

    void Update()
    {
        MovePlayer();
        CheckGrounded();
        Jump();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal"); // Get input from arrow keys or A/D
        float moveZ = Input.GetAxis("Vertical");   // Get input from arrow keys or W/S

        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void CheckGrounded()
    {
        // Check if the player is grounded by using a small sphere at the player's feet
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);
    }

    void Jump()
    {
        // Make sure the player can jump only when grounded
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
