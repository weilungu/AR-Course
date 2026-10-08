using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{
    // Inspector Values
    [SerializeField] LayerMask pickupLayer;
    
    [Header("Pickup Settings")]
    [SerializeField] GameObject pickupContainer;
    [SerializeField] int pickupCount;
    
    [Header("UI Settings")]
    [SerializeField] GameUI UI;
    
    
    // === Life Cycle === //
    void OnTriggerEnter(Collider other)
    {
        bool detectedLayer = (pickupLayer.value & (1 << other.gameObject.layer)) != 0;
        Text scoreText = UI.GetScoreText();
        
        if (detectedLayer)
        {
            pickupCount++;
            scoreText.text = $"Score: {pickupCount}";
            
            other.gameObject.SetActive(false);
        }
    }
    
    
    // === Self Method === //
    
    
    // === API === //
    public bool IsFull => pickupCount >= pickupContainer.transform.childCount;
}
