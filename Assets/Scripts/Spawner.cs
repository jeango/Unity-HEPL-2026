using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    // Spawner un objet toutes les secondes
    
    public GameObject objectToSpawn;
    public float maxYOffset;
    
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 1f);
    }


    public void Spawn()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        float newYOffset = Random.Range(-maxYOffset, maxYOffset);
        newObject.transform.position += Vector3.up * newYOffset;
    }
}
