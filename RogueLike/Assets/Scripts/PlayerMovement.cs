using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedMove = 0f;
    private Vector2 movement;
    private Rigidbody2D rb;

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
    }

    void Move()
    {
        rb.velocity = new Vector2 (movement.x * speedMove, movement.y * speedMove);
    }
}
