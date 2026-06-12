using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX =
            Input.GetAxisRaw("Horizontal");
    

    float moveZ =
        Input.GetAxisRaw("Vertical");

    movement = 
        new Vector3(moveX, 0, moveZ).normalized;

    }
    void FixedUpdate()
    {
        rb.MovePosition(
            rb.position +
            movement *
            moveSpeed *
            Time.fixedDeltaTime
        );
    }
}
