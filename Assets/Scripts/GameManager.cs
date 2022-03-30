using System.Collections;
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
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        difficulty = 1f;
        ScoreKeeper.Instance.ResetScore();

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

    public void ScorePoint() => ScoreKeeper.Instance.ScorePoint(difficulty);
}
