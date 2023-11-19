using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    Animator playerAnimator;

    [SerializeField] public int maxHealth;
    public int health;
    public bool isHurt;
    [SerializeField] GameObject blood;
    [SerializeField] GameObject hurtScreen;
    private float timerHurt;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator =  GetComponent<Animator>();
        health = maxHealth;
        isHurt = false;
    }

    // Update is called once per frame
    void Update()
    {
        //usar Update para detección de inputs:
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized; //.normalized para que en diagonal vaya a misma velocidad que en otras direcciones

        //usar update para transición de estados animator: [Idle <-> walking] 
        playerAnimator.SetFloat("Horizontal", moveX);
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

        if (isHurt)
        {
            playerAnimator.SetBool("isHurt", true);
            Instantiate(blood, transform.position, transform.rotation);
            hurtScreen.SetActive(true);


            if (health < 0)
            {
                //dragon dies
                Destroy(gameObject);
                SceneController.cambiarEscena(5);
            }

            isHurt = false;
            Destroy(blood, 1f);
           
        }
        else
        {
            timerHurt -= Time.deltaTime;
            if (timerHurt <= 0)
            {
                timerHurt = 1; //Espera 1 sec antes de dejar de estar hurt
                playerAnimator.SetBool("isHurt", false);
                hurtScreen.SetActive(false);
            }
        }

    }

    //FixedUpdate se va llamando cada vez que hay un cambio en las físicas del juego (POR DEFECTO SE LLAMA 50 VECES POR SEGUNDO)
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + (moveInput * speed * Time.fixedDeltaTime * 4));
    }

    public void TakeDamage(int damage)
    {
        isHurt = true;
        health -= damage;
    }

}
