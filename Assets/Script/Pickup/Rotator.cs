using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotateDirection = Vector3.zero;
    
    void Update()
    {
        transform.Rotate(rotateDirection * Time.deltaTime);
    }
}
