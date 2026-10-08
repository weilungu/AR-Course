using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    // Inspector
    [SerializeField] PlayerPickup pickup;
    [SerializeField] GameUI UI;

    
    // === Method === //
    public void WinActions()
    {
        GameObject winText = UI.GetWinText().gameObject;
        
        bool isWin = pickup.IsFull();
        winText.SetActive(isWin);
    }
}
