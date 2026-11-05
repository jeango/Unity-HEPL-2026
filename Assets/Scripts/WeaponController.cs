using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    public GameObject projectile;
    
    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}
