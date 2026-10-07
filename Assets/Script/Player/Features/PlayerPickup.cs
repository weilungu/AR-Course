using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    // Inspector Values
    [SerializeField] LayerMask pickupLayer;
    [SerializeField] int pickupCount;
    
    
    // === Life Cycle === //
    void OnTriggerEnter(Collider other)
    {
        bool detectedLayer = (pickupLayer.value & (1 << other.gameObject.layer)) != 0;
        if (detectedLayer)
        {
            // print($"picked up: {other.gameObject.name}");
            pickupCount++;
            other.gameObject.SetActive(false);
        }
    }
    
    
    // === Self Method === //
    
    
    // === API === //
    public int ComputeScore() => pickupCount;
    public int GetCount => pickupCount;
}
