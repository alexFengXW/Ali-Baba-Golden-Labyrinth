using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float dodgeSpeed = 20f;
    public float dodgeDuration = 0.2f;  // Duration of the dodge in seconds
    private Rigidbody rb;
    private bool isDodging = false;
    private Vector3 dodgeDirection;

    public bool controlsEnabled = true; // Variable to enable/disable player control

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!controlsEnabled) return; // Skip the update if controls are disabled

        if (!isDodging)
        {
            Move();

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                StartDodge();
            }
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * walkSpeed;

        // Only update horizontal and vertical movements, maintain current y-axis velocity to respect gravity
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }

    void StartDodge()
    {
        if (isDodging) return;  // Prevent dodging if already dodging
        dodgeDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (dodgeDirection.magnitude > 0)  // Ensure there is some direction input to dodge
        {
            dodgeDirection = dodgeDirection.normalized * dodgeSpeed;
            isDodging = true;
            Invoke("StopDodge", dodgeDuration);
        }
    }



    void StopDodge()
    {
        isDodging = false;
        rb.velocity = Vector3.zero;  // Optional: stop all movement after dodge ends
    }
}
