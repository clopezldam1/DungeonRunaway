using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //usar Update para detección de inputs:
            float moveX = Input.GetAxisRaw("Horizontal"); //devuelve -1 si le das a flecha left (or tecla "A"), devuelve 1 si le das a flecha right (or tecla "D"), devuelve 0 si no apretas ninguna de las dos
            float moveY = Input.GetAxisRaw("Vertical"); //returns 1 if up/"W", returns -1 if down/"S", returns 0 if nothing
            moveInput = new Vector2(moveX, moveY).normalized;

        //usar update para transición de estados animator:
            //[Idle <-> walking] 
            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude); 
     
    }

    //FixedUpdate se va llamando cada vez que hay un cambio en las físicas del juego (POR DEFECTO SE LLAMA 50 VECES POR SEGUNDO)
    private void FixedUpdate()
    {
        //NOTA: playerRb.position te da la posicion actual del jugador  (antes de moverse)
        playerRb.MovePosition(playerRb.position + (moveInput * speed * Time.fixedDeltaTime * 4) );
        /* Pasar por parametro pos de destino (aka, pos de donde quieres moverlo):
         * A la pos actual le sumamos 1 (bc presionas tecla 1 vez) multiplicado por la velocidad en la que se mueve el personaje multiplicsdo por FixedDeltaTime para que la velocidad sea siempre la misma independientemente del rate de refesco de fixedUpdate (FixedDeltaTime te devuelve el tiempo que ha pasado desde la última llamada a fixedUpdate) multiplicado por 4 para darle mas velocidad bc iba muy lento*/
        /* si vas en diagonal como suma el +-1 de ambas teclas, va un 40% más rápido. 
         * Si quieres que en diagonal vaya a misma velocidad que el resto de reicciones, crea el vector del moveInput así: moveInput = new Vector2(moveX, moveY).normalized;*/



    }
}
