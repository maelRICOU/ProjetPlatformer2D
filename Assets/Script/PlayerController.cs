using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    public Transform groundCheck;
    private bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;



    private int extraJumps;
    public int extraJumpsValue;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void Update()
    {

        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {

            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        {
            if ((isGrounded == false))
            {
                rb.velocity = new Vector2(); 
                if (Input.GetKeyDown("up"))
                {
                    rb.velocity = new Vector2();
                }
            }

            if ((isGrounded == false))
            {
                rb.velocity = new Vector2(); 
                if (Input.GetKeyDown("up"))
                {
                    rb.velocity = new Vector2();
                }
            }
        }
    }
}
