using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{
    // Inspector
    [SerializeField] LayerMask pickupLayer;
    
    [Header("Pickup Settings")]
    [SerializeField] GameObject[] pickupContainers;
    
    [Header("Getting UI")]
    [SerializeField] GameUI UI;
    
    // Private
    int count;
    
    
    // === API === //
    public int Count
    {
        get => count;
        set => count = value;
    }

    public bool IsFull()
    {
        foreach (GameObject container in pickupContainers)
            return count >= container.transform.childCount;
        
        return false;
    }
    public bool DetextedLayer(Collider other)
        => (pickupLayer.value & (1 << other.gameObject.layer)) != 0;
    public void UpdateScoreUI(int amount)
        => UI.GetScoreText.text = $"Score: {amount}";
}
