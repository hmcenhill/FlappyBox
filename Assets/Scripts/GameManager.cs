using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Difficulty { get => difficulty; }
    private float difficulty;

    [SerializeField] private float timeBeforeNextDifficulty = 15f;
    [SerializeField] private float difficultyIncreaseAmount = 0.1f;
    [SerializeField] private BlockerSpawner spawner;


    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        difficulty = 1f;
        StartCoroutine(nameof(IncreaseDifficulty));
        spawner.StartSpawner();
    }

    private IEnumerator IncreaseDifficulty()
    {
        yield return new WaitForSeconds(timeBeforeNextDifficulty);
        difficulty += difficultyIncreaseAmount;
        StartCoroutine(nameof(IncreaseDifficulty));
    }

    public void GameOver()
    {
        StopCoroutine(nameof(IncreaseDifficulty));
        Debug.Log("Game Over!!");
    }
}
