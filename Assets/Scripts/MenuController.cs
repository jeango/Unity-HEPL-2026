using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnPlayButton()
    {
        GameManager.StartGame();
    }

    public void OnOptionsButton()
    {
        print("OnOptions Button clicked");
        //TODO  
    }
    
    public void OnQuitButton()
    {
        GameManager.QuitGame();
    }

    public void OnMainMenuButton()
    {
        GameManager.LoadMainMenu();
    }
}
