using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;
    public static int highscore = 0;

    public static void GainScore(int amount)
    {
        score += amount;
        highscore = score > highscore ? score : highscore;
    }
    
    public static void StartGame()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        score = 0;
        SceneManager.LoadScene("Game");
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void GameOver()
    {
        PlayerPrefs.SetInt("HighScore", highscore);
        SceneManager.LoadSceneAsync("GameOver", LoadSceneMode.Additive);
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
