using UnityEngine;

public class Player : MonoBehaviour
{
    public void OnDeath()
    {
        GameManager.GameOver();
    }

    void OnDestroy()
    {
        OnDeath();
    }
}
