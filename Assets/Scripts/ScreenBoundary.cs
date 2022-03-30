using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundary : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            GameManager.Instance.GameOver();
        }
    }
}