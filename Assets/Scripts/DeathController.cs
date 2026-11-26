using UnityEngine;

public class DeathController : MonoBehaviour
{
    public int score;
    
    void GainScore()
    {
        GameManager.OnGainScore(score);
        print(GameManager.score);
    }

    public void Kill()
    {
        GainScore();
        Destroy(gameObject);
    }
}
