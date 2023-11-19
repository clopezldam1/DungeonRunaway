using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisparoBolaFuego : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject fireBall;

    // Update is called once per frame
    void Update()
    {
        //si juego no está en pausa, puedes disparar
        if (!SceneController.pause) {
            //GetMouseButtonDown -> param 'button': 0=left, 1=right, 2=middle
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(fireBall, shootingPoint.position, transform.rotation);
            }
        }
      
    }
}
