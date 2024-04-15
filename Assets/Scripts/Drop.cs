using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float dropTime = 3;
    void Start() {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }
    void Update()
    {
        if (dropTime < Time.time) {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
} 
