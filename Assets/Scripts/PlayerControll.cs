using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector2 moveInput = new Vector2(inputX, inputY).normalized;
        Vector2 moveVelocity = moveInput * moveSpeed;

        rb.linearVelocity = moveVelocity;
    }
}
