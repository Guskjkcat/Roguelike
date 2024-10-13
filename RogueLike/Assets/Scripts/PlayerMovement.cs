using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMove = 0f;
    Rigidbody2D rb;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();

    }

    void FixedUpdate()
    {
        Move();
    }

    void InputManagement()
    {
        float moveY = Input.GetAxisRaw("Horizontal");
        float moveX = Input.GetAxisRaw("Vertical");

        movement = new Vector2(moveY, moveX).normalized;

        if (movement.x != 0)
        {
            lastHorizontalVector = movement.x;
        }

        if (movement.y != 0)
        {
            lastVerticalVector = movement.y;
        }
    }

    void Move()
    {
        rb.velocity = new Vector2 (movement.x * speedMove, movement.y * speedMove);
    }
}
