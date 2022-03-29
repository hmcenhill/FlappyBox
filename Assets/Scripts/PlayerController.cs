using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 jumpPower = Vector2.up * 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //TODO: Change input control
        if (Input.GetButtonDown("Fire1"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = jumpPower;
    }
}