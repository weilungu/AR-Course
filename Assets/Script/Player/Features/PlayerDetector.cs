using System;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public bool isGameOver;
    
    
    // === Life Cycle === //
    void OnTriggerEnter(Collider other)
    {
        isGameOver = other.CompareTag("Lose");
    }
}
