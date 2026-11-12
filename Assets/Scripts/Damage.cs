using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        if (damageable != null)
        {
            damageable.TakeDamage();
        }
    }
}
