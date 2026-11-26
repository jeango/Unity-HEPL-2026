using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;
    
    void DisplayScore(int score)
    {
        scoreText.text = score.ToString();
    }

    void DisplayHiScore(int score)
    {
        hiScoreText.text = score.ToString();
    }

    void Update()
    {
        DisplayScore(GameManager.score);
        DisplayHiScore(GameManager.highscore);
    }
}
