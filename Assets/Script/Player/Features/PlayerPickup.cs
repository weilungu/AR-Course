using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    [SerializeField] LayerMask pickupLayer;
    
    // === Life Cycle === //
    void OnTriggerEnter(Collider other)
    {
        bool detectedLayer = (pickupLayer.value & (1 << other.gameObject.layer)) != 0;
        if (detectedLayer)
        {
            // print($"picked up: {other.gameObject.name}");
            other.gameObject.SetActive(false);
        }
    }
}
