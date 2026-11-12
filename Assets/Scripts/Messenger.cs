using UnityEngine;

public class Messenger : MonoBehaviour
{
    public string message;
    
    private int counter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(message);
    }

    // Update is called once per frame
    void Update()
    {
        print(counter);
        counter = counter + 1;
    }
}
