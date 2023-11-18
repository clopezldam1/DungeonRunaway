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
                if (pause)
                {
                    //cerrar menu pausa
                    LaunchPauseMenu.closePauseMenu(overlapScene);
                    pause = false;

                }
                else
                {
                    //abrir menu pausa
                    LaunchPauseMenu.launchPauseMenu(overlapScene);
                    pause = true;
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
}
