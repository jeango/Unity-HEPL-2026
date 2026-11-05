using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }


    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = direction.normalized;
        transform.position += movement * (Time.fixedDeltaTime * speed);
    }
}
