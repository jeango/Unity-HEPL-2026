using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInteral;
    public float maxYOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnInteral, spawnInteral);
    }

    public void Spawn()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        Vector3 newPosition = newObject.transform.position;
        // set y to -4 <-> 4
        float newY = Random.Range(-maxYOffset, maxYOffset);
        newPosition.y = newY;
        newObject.transform.position = newPosition;
    }

}
