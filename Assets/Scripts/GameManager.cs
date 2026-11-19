using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;

    public static void GainScore(int amount)
    {
        score += amount;
    }
    
    public static void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
