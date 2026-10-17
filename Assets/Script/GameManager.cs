using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    // Inspector
    [SerializeField] PlayerPickup pickup;
    [SerializeField] GameUI UI;
    
    [Header("Debugger")]
    [SerializeField] bool isWon;
    [SerializeField] bool isGameOver;
    
    // Private
    int score;
    
    
    // === API === //
    public void OutcomeActions()
    {
        isWon = IsWon();
        isGameOver = IsGameOver();

        Text outcome = UI.GetOutcomeText;
        if (isGameOver)
        {
            outcome.text = isWon
                ? "You win!"
                : "You lose!";
            
            outcome.gameObject.SetActive(isGameOver);
        }

    }

    public bool IsWon() => pickup.IsFull();
    public bool IsGameOver() => Input.GetKeyDown(KeyCode.Space);
    public void AddScore(int amount)
    {
        score += amount;
        UI.UpdateScoreUI(score);
    }
}
