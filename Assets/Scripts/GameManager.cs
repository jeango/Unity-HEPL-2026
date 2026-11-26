using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;

    public static void OnGainScore(int value)
    {
        score += value;
    }
    
    public static void OnGameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public static void OnGameOver()
    {
        SceneManager.LoadSceneAsync("GameOver", LoadSceneMode.Additive);        
    }

    public static void OnGameQuit()
    {
        Application.Quit();
    }

    public static void OnOpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}