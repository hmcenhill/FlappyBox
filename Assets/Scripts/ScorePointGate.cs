using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePointGate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            GameManager.Instance.ScorePoint();
            Destroy(this.gameObject);
        }
    }
}