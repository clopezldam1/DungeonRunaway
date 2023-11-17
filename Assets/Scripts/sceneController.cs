using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Update()
    {
        //si jugador presiona cualquiera de esas dos teclas estando en nivel 1, te carga de menu pausa superpuesto
        if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
            {
                cargarEscena("PauseMenu");
            }
        }
    }

    public void cambiarEscena(string nomEscena)
    {
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(nomEscena);
        // SceneManager.UnloadSceneAsync(current); //NOT SUPPORTED, FINF ALTERNATIVE

    }

    public void cerrarEscena(string nomEscena)
    {
        SceneManager.UnloadSceneAsync(nomEscena); //método deprecated, busca otro????? esto no funciona

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
