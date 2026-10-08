using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{
    // Inspector
    [SerializeField] LayerMask pickupLayer;
    
    [Header("Pickup Settings")]
    [SerializeField] GameObject[] pickupContainers;
    
    [Header("UI Settings")]
    [SerializeField] GameUI UI;
    
    // Private
    int pickupCount;
    
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
    public bool IsFull()
    {
        foreach (GameObject container in pickupContainers)
            return pickupCount >= container.transform.childCount;
        
        return false;
    }
}
