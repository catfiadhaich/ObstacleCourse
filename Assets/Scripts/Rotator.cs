using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float xRot = 0f;
    [SerializeField] private float yRot = 0f;
    [SerializeField] private float zRot = 0f;

    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}