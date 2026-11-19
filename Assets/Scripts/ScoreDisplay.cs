using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    void DisplayScore(int score)
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        DisplayScore(GameManager.score);
    }
}
