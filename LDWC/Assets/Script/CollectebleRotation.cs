using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectebleRotation : MonoBehaviour
{
    public float RoationSpeed;

    // Update is called once per frame

    void Update()
    {
        transform.Rotate(0, RoationSpeed, 0, Space.World);
    }
}
