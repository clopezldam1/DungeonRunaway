using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BatEnemy;

public class ChaseControlEnemy : MonoBehaviour
{
    public BatWaitTrigger[] grupoEnemigos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!SceneController.pause)
        {
            if (collision.CompareTag("Player"))
            {
                foreach (BatWaitTrigger enemigo in grupoEnemigos)
                {
                    enemigo.chase = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!SceneController.pause)
        {
            if (collision.CompareTag("Player"))
            {
                foreach (BatWaitTrigger enemigo in grupoEnemigos)
                {
                    enemigo.chase = false;
                }
            }
        }
    }



}
