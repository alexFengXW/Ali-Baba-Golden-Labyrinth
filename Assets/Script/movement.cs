using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    private Rigidbody rb;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GroundCheck();
        Move();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint();
        }
    }

    void GroundCheck()
    {
        // Check if the player is grounded by performing a sphere check directly beneath the player
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * walkSpeed;

        // Only update horizontal and vertical movements, maintain current y-axis velocity to respect gravity
        Vector3 newVelocity = new Vector3(movement.x, rb.velocity.y, movement.z);
        rb.velocity = newVelocity;
    }

    void Sprint()
    {
        if (isGrounded)  // Allow sprinting only when the player is grounded
        {
            Vector3 sprintVelocity = rb.velocity.normalized * sprintSpeed;
            // Maintain y-axis velocity from existing Rigidbody velocity to ensure gravity is applied
            rb.velocity = new Vector3(sprintVelocity.x, rb.velocity.y, sprintVelocity.z);
        }
    }
}