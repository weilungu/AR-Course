using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Awake Values
    PlayerMovement move;
    
    
    // === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.Movement();
    }
    
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Pickup"))
    //     {
    //         other.gameObject.SetActive(false);
    //         Destroy(other.gameObject);
    //     }
    // }
}
