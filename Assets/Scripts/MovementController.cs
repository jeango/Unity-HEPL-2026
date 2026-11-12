using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = direction.normalized * speed;
        transform.position += movement * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}
