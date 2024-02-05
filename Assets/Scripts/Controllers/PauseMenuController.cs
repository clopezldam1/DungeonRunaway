using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public void setPause(bool pause) 
    {
        SceneController.pause = pause;
    }
    public bool getPause()
    {
        return SceneController.pause;
    }
    public static void launchPauseMenu(GameObject pauseMenu) {
        pauseMenu.SetActive(true);
        SceneController.pause = true;
        Time.timeScale = 0f; //freeze game
    }
    public static void closePauseMenu(GameObject pauseMenu)
    {
        pauseMenu.SetActive(false);
        SceneController.pause = false;
        Time.timeScale = 1f; //unfreeze game
    }
}
