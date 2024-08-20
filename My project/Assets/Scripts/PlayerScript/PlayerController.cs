using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * moveInput * moveSpeed * Time.deltaTime);
    }

    void Rotate()
    {
        float rotateInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * -rotateInput * rotationSpeed * Time.deltaTime);
    }
}
