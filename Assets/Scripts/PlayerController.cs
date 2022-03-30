using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 jumpPower = Vector2.up * 5f;
    [SerializeField] private float recoverSpeed = 0.2f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(this.transform.position.x < 0f)
        {
            MoveForward();
        }

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

    private void MoveForward()
    {
        this.transform.position += Vector3.right * Time.deltaTime * recoverSpeed;
    }
}