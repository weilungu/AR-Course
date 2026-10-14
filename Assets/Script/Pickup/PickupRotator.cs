using System;
using UnityEngine;

public class PickupRotator : MonoBehaviour
{
    // Inspector
    [SerializeField, Range(-100, 100)]
    float rotateSpeed = 10f;

    
    // Private
    Vector3 rotateDirection;

    
    // === Life Cycle === //
    void Start()
    {
        rotateDirection = Vector3.forward * rotateSpeed;
    }

    void Update()
    {
        transform.Rotate(rotateDirection * Time.deltaTime);
    }
}
