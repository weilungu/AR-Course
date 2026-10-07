using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    // Inspector
    [SerializeField] PlayerPickup pickup;
    [SerializeField] GameUI UI;

    
    // === Method === //
    public void IsWin()
    {
        bool isWin = pickup.GetCount >= 5;
        UI.GetWinText().gameObject.SetActive(isWin);
    }
}
