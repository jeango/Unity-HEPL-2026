using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float timeToDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

}
