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


    void Test()
    {

        if (Input.GetMouseButtonDown(0))
        {
            scoreText.text = $"score: {count}";
            count++;
        }
        
        if (Input.GetMouseButtonDown(1))
            winText.gameObject.SetActive(true);
    }
}
