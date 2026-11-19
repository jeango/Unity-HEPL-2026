using UnityEngine;

public class Messenger : MonoBehaviour
{
    public string message;

    private int _counter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(gameObject.name + ": " + message);
    }

    // Update is called once per frame
    void Update()
    {
        print(_counter);
        _counter++;
    }
}
