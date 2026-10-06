using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    [SerializeField] string[] objTags;
    
    
    // === Life Cycle === //
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(objTags[0]))
        {
            print($"Picked up {other.gameObject.name}");
            other.gameObject.SetActive(false);
        }
    }
}
