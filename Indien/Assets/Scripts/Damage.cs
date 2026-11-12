using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Damageable otherDamageable = other.GetComponent<Damageable>();
        if (otherDamageable != null)
        {
            otherDamageable.TakeDamage();
        }
    }
}
