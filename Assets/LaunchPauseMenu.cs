using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class LaunchPauseMenu : MonoBehaviour
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
        //Scene activeScene = SceneManager.GetActiveScene();
        //activeScene.GetRootGameObjects();
        Instantiate(pauseMenu);
        SceneController.pause = true;
    }
    public static void closePauseMenu(GameObject pauseMenu)
    {
        Object.Destroy(pauseMenu);
        SceneController.pause = false;
    }

}
