using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    // Awake Values
    GameUI UI;
    
    
    // === Life Cycle === //
    void Awake()
    {
        UI = GetComponent<GameUI>();
    }

    void Update()
    {
        UI.Test();
    }
}
