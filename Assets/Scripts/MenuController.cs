using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void StartGame()
    {
        GameManager.OnGameStart();
    }

    public void OpenOptionsMenu()
    {
        // TODO
    }
    
    public void QuitGame()
    {
        GameManager.OnGameQuit();
    }
}