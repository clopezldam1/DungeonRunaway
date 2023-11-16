using SimpleInputNamespace;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void Update()
    {
        //si jugador presiona cualquiera de esas dos teclas estando en nivel 1, te pone overlay de menu pausa

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            cargarEscena("PauseMenu");
        }
    }

    public void cambiarEscena(string nomEscena)
    {
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(nomEscena);
        SceneManager.UnloadSceneAsync(current);

    }

    public void cerrarEscena(string nomEscena)
    {
        SceneManager.UnloadSceneAsync(nomEscena); //método deprecated, busca otro????? no funciona

        //Scene inGame  = SceneManager.GetSceneByName("Level1");
        //SceneManager.SetActiveScene(inGame);
    }

    public void cargarEscena(string nomEscena)
    {
        SceneManager.LoadScene(nomEscena);
    }

    public void cerrarJuego()
    {
        Application.Quit();
    }
}
