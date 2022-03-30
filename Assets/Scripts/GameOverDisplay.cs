using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreDisplay;
    [SerializeField] private GameObject newHighScoreDisplay;

    public void UpdateDisplay()
    {
        scoreDisplay.text = $"Your Score: {ScoreKeeper.Instance.Score}!";
        newHighScoreDisplay.SetActive(ScoreKeeper.Instance.Score == ScoreKeeper.Instance.HighScore);
    }
}