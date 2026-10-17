using System;
using UnityEngine;

public class PickupRotator : MonoBehaviour
{
    // Inspector
    [SerializeField, Range(-100, 100)]
    float rotateVector = 10f;

    
    // Private
    Vector3 direction;

    
    // === Life Cycle === //
    void Start()
    {
        direction = Vector3.forward * rotateVector;
    }

    void Update()
    {
        transform.Rotate(direction * Time.deltaTime);
    }
}
