using UnityEngine;

public partial class UIController : MonoBehaviour
{
    [SerializeField] private GameObject scoreDisplay;
    [SerializeField] private GameObject gameStartDisplay;
    [SerializeField] private GameOverDisplay gameOverDisplay;

    public void ShowScores() => DisplayToggle(DisplayName.Score);
    public void ShowGameStart() => DisplayToggle(DisplayName.GameStart);
    public void ShowGameOver() => DisplayToggle(DisplayName.GameOver);

    private void DisplayToggle(DisplayName name)
    {
        scoreDisplay.SetActive(false);
        gameStartDisplay.SetActive(false);
        gameOverDisplay.gameObject.SetActive(false);

        switch (name)
        {
            case DisplayName.Score:
                scoreDisplay.SetActive(true);
                break;
            case DisplayName.GameStart:
                gameStartDisplay.SetActive(true);
                break;
            case DisplayName.GameOver:
                gameOverDisplay.gameObject.SetActive(true);
                gameOverDisplay.UpdateDisplay();
                break;
        }
    }
}