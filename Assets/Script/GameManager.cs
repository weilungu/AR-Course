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
        bool isWin = pickup.IsFull;
        UI.GetWinText().gameObject.SetActive(isWin);
    }
}
