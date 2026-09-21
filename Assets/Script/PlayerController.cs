using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Awake Values
    Rigidbody rb;
    
    // Values
    [SerializeField] float speed = 1f;
    
    // Private Values
    float moveX, moveY;

    
    // === Life Cycle === //
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX, 0f, moveY);
        rb.AddForce(movement * speed);
    }


    void OnMove(InputValue moveValue)
    {
        Vector2 vector = moveValue.Get<Vector2>();
        moveX = vector.x;
        moveY = vector.y;
    }
}
