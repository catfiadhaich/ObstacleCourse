using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float waitTime = 3.0f;
    private Rigidbody dropperBody;

    private void Awake() {
        dropperBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Time.time >= waitTime) {
            dropperBody.useGravity = true;      
        }
    }
}
