using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public UnityEvent OnDeath;
    
    public void TakeDamage()
    {
        OnDeath?.Invoke();
        Destroy(gameObject);
    }
}
