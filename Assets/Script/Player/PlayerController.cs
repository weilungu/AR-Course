using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Awake
    PlayerMovement move;
    GameManager GM;
    PlayerPickup pickup;
    
    
    // === Life Cycle === //
    void Awake()
    {
        GM = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>();
        
        move = GetComponent<PlayerMovement>();
        pickup = GetComponent<PlayerPickup>();
    }
    void Update()
    {
        GM.WinActions();
    }
    void FixedUpdate()
    {
        move.Movement();
    }
    
    //
    void OnTriggerEnter(Collider other)
    {
        bool layerDetected = pickup.DetextedLayer(other);

        if (!layerDetected) return;
        pickup.Count++;
        pickup.UpdateScoreUI(pickup.Count);
        
        other.gameObject.SetActive(false);
    }
}
