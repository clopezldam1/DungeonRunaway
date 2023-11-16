using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatWaitTrigger : MonoBehaviour
{
    [SerializeField] int maxHealth;
    private int health;
    private Rigidbody2D rb;

    public float speed;
    private GameObject player;
    public bool chase = false;
    public Transform startingPoint;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (chase == true)
        {
            ChasePlayer();
            FacingDirectionFlip();
        }
        else
        {
            //go to starting position
           ReturnToStartPos();
        }
      
    }

    //m�todo que hace que el enemigo siga al jugador por el mapa
    private void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, player.transform.position) <= 0.5f)
        {
            //enemy attacks here bc its within reach
        }
        else
        {
            //reset variables
        }
    }

   //m�todo para que enemigo siempre mire en direcci�n al jugador mientras le persigue
    private void FacingDirectionFlip() 
    {
        //si el enemigo est� a la derecha del jugador.... 
        if (transform.position.x > player.transform.position.x) {
            //cambiamos facingDirection del enemy(que debido al sprite que estamos usando, es la derecha) para que mire hacia la izquierda
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //si el enemigo est� a la izquierda del jugador, el enemigo mirar� a la derecha por defecto
    }

    //m�todo que hace que enemigo se de la vuelta y regrese a su posicion original cuando jugador no est� dentro de su rango de ataque
    private void ReturnToStartPos()
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);

    }
}
