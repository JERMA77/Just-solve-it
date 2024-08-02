using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(1 * speed, rb.velocity.y);
        //rb.AddForce(direction, ForceMode2D.Impulse);
    }

    
    void FixedUpdate()
    {
        rb.velocity = direction;
    }
}
