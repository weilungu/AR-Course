using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Awake
    PlayerMovement move;
    GameManager GM;
    
    
    // === Life Cycle === //
    void Awake()
    {
        GM = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>();
        
        move = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        GM.WinActions();
    }

    void FixedUpdate()
    {
        move.Movement();
    }
}
