using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void DisplayScore()
    {
        scoreText.text = GameManager.score.ToString();
        highScoreText.text = GameManager.highscore.ToString();
    }

    void Update()
    {
        DisplayScore();
    }
}
