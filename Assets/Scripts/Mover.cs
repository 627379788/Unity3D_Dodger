using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }
    void Move(){
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, -zValue);
    }
}
