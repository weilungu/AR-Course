using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Inspector Values
    [SerializeField] Text scoreText;
    [SerializeField] Text winText;
    
    // Private
    int score;
    

    // === API === //
    public void UpdateScoreUI(int amount)
        => scoreText.text = $"Score: {amount}";
    
    public Text GetWinText => winText;
    public Text GetScoreText => scoreText;
}
