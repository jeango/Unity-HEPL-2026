using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int score;

    public void ScorePoints()
    {
        GameManager.GainScore(score);
    }
    
}
