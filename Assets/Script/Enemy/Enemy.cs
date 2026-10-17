using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Awake
    GameManager GM;
    EnemyMovement movement;
    
    // Inspector
    [SerializeField] Transform target;
    
    
    // === Life Cycle === //
    void Awake()
    {
        GM = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>();

        movement = GetComponent<EnemyMovement>();
    }

    void Update()
    {
        if (GM.IsGameOver()) return;
        
        movement.Chase(target);
    }
}
