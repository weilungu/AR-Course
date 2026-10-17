using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Inspector
    [SerializeField] Text scoreText;
    [SerializeField] Text outcomeText;
    
    [SerializeField] PlayerPickup pickup;
    

    // === API === //
    public void UpdateScoreUI(int amount)
        => scoreText.text = $"Score: {amount} / {pickup.Amount}";
    
    public Text GetOutcomeText() => outcomeText;
}
