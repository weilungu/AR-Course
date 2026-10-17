using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{
    // Inspector
    [SerializeField] LayerMask pickupLayer;
    
    [Header("Pickup Settings")]
    [SerializeField] GameObject pickupContainer;
    
    // Private
    int count;
    
    
    // === API === //
    public int Count
    {
        get => count;
        set => count = value;
    }

    public bool IsFull()
        => count >= pickupContainer.transform.childCount;
    
    public bool DetextedLayer(Collider other)
        => (pickupLayer.value & (1 << other.gameObject.layer)) != 0;
}
