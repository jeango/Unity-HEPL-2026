using UnityEngine;

public class DestroyOthersOnTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
