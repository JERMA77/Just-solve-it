using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVector;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");

        if (moveVector.x > 0)
        {
            rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        }
        else if (moveVector.x > 0)
        {
            rb.MovePosition(rb.position - moveVector * speed * Time.deltaTime);
        }
    }
}
