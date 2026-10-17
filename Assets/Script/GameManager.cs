using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    // Inspector
    [SerializeField] PlayerDetector detector;
    [SerializeField] PlayerPickup pickup;
    [SerializeField] GameUI UI;
    
    [Header("Debugger")]
    [SerializeField] bool isWin;
    [SerializeField] bool isGameOver;
    
    // Private
    int score;
    Text outcomeText;
    
    
    // === API === //
    public void OutcomeActions()
    {
        isWin = IsWin();
        isGameOver = IsGameOver();
        outcomeText = UI.GetOutcomeText();

        if (isWin) isGameOver = true;
        
        if (!isGameOver) return;
        outcomeText.text = isWin
            ? "You win!"
            : "You lose!";
            
        outcomeText.gameObject.SetActive(isGameOver);
    }

    public bool IsWin() => pickup.IsFull();
    public bool IsLose() => isGameOver && !isWin;
    public bool IsGameOver() => isGameOver || detector.isGameOver;
    
    public void AddScore(int amount)
    {
        score += amount;
        UI.UpdateScoreUI(score);
    }
}
