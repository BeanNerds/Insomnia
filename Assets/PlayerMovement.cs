using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    public Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // Fix diagonal glitch
        movement.Normalize();

        rb.velocity = new Vector2(movement.x * movementSpeed * Time.fixedDeltaTime, 
            movement.y * movementSpeed * Time.fixedDeltaTime);
    }
}
