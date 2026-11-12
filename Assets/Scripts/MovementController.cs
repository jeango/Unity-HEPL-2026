using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    private Rigidbody2D _body;

    void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (_body != null && _body.bodyType == RigidbodyType2D.Dynamic)
        {
            _body.linearVelocity = direction.normalized * speed;
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
