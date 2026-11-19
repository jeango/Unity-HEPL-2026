using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnStartButton()
    {
        GameManager.StartGame();
    }

    public void OnOptionsButton()
    {
        print("Options button clicked");
    }

    public void OnQuitToMainMenuButton()
    {
        GameManager.LoadMainMenu();
    }
    
    public void OnQuitButton()
    {
        GameManager.QuitGame();
    }
}
