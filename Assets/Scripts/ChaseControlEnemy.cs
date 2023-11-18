using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
