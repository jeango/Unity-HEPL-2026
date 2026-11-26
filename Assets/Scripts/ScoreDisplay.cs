using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;


    public void DisplayScore()
    {
        scoreText.text = GameManager.score.ToString();
        highscoreText.text = GameManager.highscore.ToString();
    }

    void Update()
    {
        DisplayScore();
    }
}
