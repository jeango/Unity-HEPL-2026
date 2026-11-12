using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    
    private Rigidbody2D body;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (body && body.bodyType == RigidbodyType2D.Dynamic)
        {
            body.linearVelocity = direction * speed;
        }
        else
        {
            Vector3 movement = direction.normalized;
            transform.position += movement * (Time.fixedDeltaTime * speed);
        }
    }
    

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }


    
}
