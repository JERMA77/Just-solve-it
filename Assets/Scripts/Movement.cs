using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float startSpeed;
    public float maxSpeed;
    public float jumpForce;
    public bool isGrounded;

    public int jump;

    public int doubleJump;
    private bool doubleJumpReady = true;

    public int changeGravity;
    public int shoot;
    public int invisibility;

    private Rigidbody2D rb;
    private Vector2 direction;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        direction = new Vector2(rb.mass * startSpeed, rb.velocity.y);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (isGrounded && jump != 0)
            {
                Jump();
                jump--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (isGrounded && doubleJump != 0) Jump();
            else if (!isGrounded && doubleJump != 0 && doubleJumpReady)
            {
                Jump();
                doubleJump--;
                doubleJumpReady = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (changeGravity != 0)
            {
                ChangeGravity();
                changeGravity--;
            }
        }
    }


    void FixedUpdate()
    {
        rb.AddForce(direction);
        if (rb.velocity.x > maxSpeed) rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0, rb.mass * jumpForce), ForceMode2D.Impulse);
        isGrounded = false;
        Debug.Log("Прыг");
    }

    private void ChangeGravity()
    {
        rb.gravityScale *= -1;
        sprite.flipY = !sprite.flipY;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
            doubleJumpReady = true;
        }
    }
}
