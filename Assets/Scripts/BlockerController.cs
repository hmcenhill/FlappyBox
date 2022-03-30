using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;

    private void Start()
    {
        SetValues();
    }

    private void SetValues()
    {
        this.transform.position = new Vector3(14f, Random.Range(-4f, 4f), 0f);
        moveSpeed *= GameManager.Instance.Difficulty;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if(this.transform.position.x <= -14)
        {
            Destroy(this.gameObject);
        }
        this.transform.position += Vector3.left * Time.deltaTime * moveSpeed;
    }
}