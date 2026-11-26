using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static int score = 0;
    public static int highscore = 0;
    
    public static void StartGame()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        SceneManager.LoadScene("Game");
    }

    public static void UpdateHighScore()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("HighScore", highscore);
        }
    }
    
    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void GameOver()
    {
        SceneManager.LoadSceneAsync("GameOver", LoadSceneMode.Additive);
    }
}
