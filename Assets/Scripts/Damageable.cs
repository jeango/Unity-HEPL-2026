using UnityEngine;

public class Damageable : MonoBehaviour
{
    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
