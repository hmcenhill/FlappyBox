using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance;

    private float score;
    private float highScore;

    [SerializeField] private TextMeshProUGUI scoreDisplay;
    [SerializeField] private TextMeshProUGUI highScoreDisplay;
    [SerializeField] private TextMeshProUGUI difficultyDisplay;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            highScore = 0f;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ResetScore()
    {
        score = 0f;
        UpdateDisplay();
    }

    public void ScorePoint(float value)
    {
        score += value;
        if(score > highScore)
        {
            highScore = score;
        }
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        scoreDisplay.text = ((int)score).ToString();
        highScoreDisplay.text = ((int)highScore).ToString();
        difficultyDisplay.text = GameManager.Instance.Difficulty.ToString("0.0");
    }
}