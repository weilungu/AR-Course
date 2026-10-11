using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Inspector Values
    [SerializeField] Text scoreText;
    [SerializeField] Text winText;
    

    // === API === //
    public Text GetWinText => winText;
    public Text GetScoreText => scoreText;
}
