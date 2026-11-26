using UnityEngine;

public class Damageable : MonoBehaviour
{
    private DeathController _deathController;

    void Awake()
    {
        _deathController = GetComponent<DeathController>();
    }
    
    public void TakeDamage()
    {
        if (_deathController != null)
        {
            _deathController.Kill();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
