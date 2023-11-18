using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject overlapScene;
    [SerializeField] bool canScenePause = false;
    public static bool pause; //if game is currently being paused or not

    public void Start()
    {
        pause = false;
    }

    public void Update()
    {
        //si jugador presiona cualquiera de esas dos teclas estando en un nivel, te carga el menu pausa superpuesto
        if (canScenePause)
        {
            //puedes abrir y cerrar menu pausa con "P" o "Escape"
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)){
                if (isPaused())
                {
                    //cerrar menu pausa
                    LaunchPauseMenu.closePauseMenu(overlapScene);
                    //cerrarEscena(overlapScene, this.GetComponentInParent<Scene>(),true);
                    //pause = false;

                }
                else
                {
                    //abrir menu pausa
                    LaunchPauseMenu.launchPauseMenu(overlapScene);
                    //cargarEscena(overlapScene);
                    //pause = true;
                }
            }
        }
    }

    public bool isPaused()
    {
        return pause;
    }

    /*
     Salir del juego
     */
    public void cerrarJuego()
    {
        Application.Quit();
    }

    /*
     Carga una escena cerrando la anterior
     */
    public static void cambiarEscena(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Single);
    }

    /*
     Carga una escena(as GameObject) encima de otra sin cerrar la anterior(superpuesta)
     */
    public static void cargarEscena(GameObject overlapScene)
    {
        Instantiate(overlapScene);
    }
    public static void cargarEscena(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Additive);
    }

    /*
     Elimina de la escena principal los objetos de la escena superpuesta (alternativa no deprecated al unloadScene para las additive scenes)
     */
    public static void cerrarEscenaSuperpuesta(GameObject overlapScene, Scene scene)
    {
      foreach (GameObject child in scene.GetRootGameObjects())
        {
            if (child.tag.Equals("PauseMenu")){
                Object.Destroy(child);
            }
        }
    }
    public void cerrarEscena(GameObject overlapScene, Scene scene, bool pause)
    {
        //this.pause = pause;
        foreach (GameObject child in scene.GetRootGameObjects())
        {
            if (child.tag.Equals("PauseMenu"))
            {
                Object.Destroy(child);
            }
          
        }
    }


}
