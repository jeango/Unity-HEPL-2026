using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static void OnGameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public static void OnGameOver()
    {
        SceneManager.LoadScene("GameOver");        
    }

    public static void OnGameQuit()
    {
        Application.Quit();
    }
}