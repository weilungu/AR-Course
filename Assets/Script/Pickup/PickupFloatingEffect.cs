using System;
using UnityEngine;

public class PickupFloatingEffect : MonoBehaviour
{
    // Inspector
    [SerializeField, Range(0f, 5f)] float frequency = 2.5f;
    [SerializeField, Range(0f, 1f)] float fluctuation = 0.5f;
    
    // Private
    Vector3 startPos;

    
    // === Life Cycle === //
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 currPos = transform.position;
        float offset = startPos.y + Mathf.Sin(Time.time * frequency) * fluctuation;
        
        transform.position = new Vector3(currPos.x, offset, currPos.z);
    }
}
