using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public UnityEvent OnDeath;
    
    public void TakeDamage()
    {
        Kill();
    }

    public void Kill()
    {
        OnDeath?.Invoke();
        Destroy(gameObject);
    }
}
