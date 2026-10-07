using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    // Inspector Values
    [SerializeField] PlayerPickup pickup;
    [SerializeField] GameUI UI;

    
    // === Life Cycle === //
    void Update()
    {
        IsWin();
    }

    // === Method === //
    public void IsWin()
    {
        bool isWin = pickup.GetCount >= 5;
        UI.GetWinText().gameObject.SetActive(isWin);
    }
}
