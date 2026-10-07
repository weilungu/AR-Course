using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text winText;
    
    // Awake Values
    PlayerPickup pickup;
    
    int count = 0;
    
    
    
    // === Life Cycle === //
    void Awake()
    {
        pickup = GetComponent<PlayerPickup>();
    }


    public void Test()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("click left mouse button");
            scoreText.text = $"score: {count}";
            count++;
        }
        
        if (Input.GetMouseButtonDown(1))
            winText.gameObject.SetActive(true);
    }
}
