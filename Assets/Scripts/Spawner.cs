using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeBetweenSpawns;

    void Start()
    {
        if (timeBetweenSpawns > 0)
        {
            InvokeRepeating(nameof(Spawn), timeBetweenSpawns, timeBetweenSpawns);
        }
    }
    
    public void Spawn()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Spawn();
        }
    }
}
