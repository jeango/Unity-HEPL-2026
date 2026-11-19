using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static void StartGame()
    {
        SceneManager.LoadScene("Game");
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
