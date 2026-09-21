using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Inspector Values
    [SerializeField] GameObject target;
    
    // Private Values
    Vector3 offset;

    
    // === Life Cycle === //
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
