using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint();
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * walkSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }

    void Sprint()
    {
        Vector3 sprint = rb.velocity.normalized * sprintSpeed;
        rb.velocity = new Vector3(sprint.x, rb.velocity.y, sprint.z);
    }
}
