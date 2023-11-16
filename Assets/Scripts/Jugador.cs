using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Flip();
        //RestoreRotate();
      

        //usar Update para detección de inputs:
        float moveX = Input.GetAxisRaw("Horizontal"); 
            float moveY = Input.GetAxisRaw("Vertical");
            moveInput = new Vector2(moveX, moveY).normalized; //.normalized para que en diagonal vaya a misma velocidad que en otras direcciones

        //usar update para transición de estados animator:
            //[Idle <-> walking] 
            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

            //[Idle <-> hit] 
            //todo

            //[walking <-> hit] 
            //todo

            //[hit <-> dead] 
            //todo

            //[idle <-> attack] 
            //todo
    }

    //FixedUpdate se va llamando cada vez que hay un cambio en las físicas del juego (POR DEFECTO SE LLAMA 50 VECES POR SEGUNDO)
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + (moveInput * speed * Time.fixedDeltaTime * 4) );
    }

    private void Flip()
    {
        if (Input.GetMouseButtonDown(0))  //(Mouse.current.leftButton.wasPressedThisFrame)
            {
            transform.Rotate(0, 180, 0);
        }
    }
    private void RestoreRotate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(0, 0, 0);
        }
    }
}
