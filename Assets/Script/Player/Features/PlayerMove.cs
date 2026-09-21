using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    // Awake Values
    Rigidbody rb;
    
    // Inspector Values
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
    
    
    // === Self Method === //
    void OnMove(InputValue values)
    {
        Vector2 moveVectors = values.Get<Vector2>();
        moveX = moveVectors.x;
        moveY = moveVectors.y;
    } // 偵測 InputSystem 輸入
}
