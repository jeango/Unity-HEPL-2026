using UnityEngine;

public class GainScore : MonoBehaviour
{
    public int score;
    
    public void ScoreGain()
    {
        GameManager.score += score;    
    }
}
