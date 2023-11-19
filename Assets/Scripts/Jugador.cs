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
    [SerializeField] public int maxHealth;
    public int health;
    [SerializeField] GameObject blood;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    { 
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
            //playerAnimator.SetFloat("Health", health);

            //[idle <-> attack] 
            //todo
    }

    //FixedUpdate se va llamando cada vez que hay un cambio en las físicas del juego (POR DEFECTO SE LLAMA 50 VECES POR SEGUNDO)
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + (moveInput * speed * Time.fixedDeltaTime * 4) );
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(blood);
            Destroy(gameObject);
            SceneController.cambiarEscena(5);
        }
    }
}
