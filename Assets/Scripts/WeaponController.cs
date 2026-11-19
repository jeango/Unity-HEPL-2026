using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    public GameObject projectile;
    
    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}
