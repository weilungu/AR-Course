using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        Vector3 rotate = new Vector3(15f, 30f, 45f);
        
        transform.Rotate(rotate * Time.deltaTime);
    }
}
