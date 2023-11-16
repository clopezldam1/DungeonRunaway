using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFollow : MonoBehaviour
{
    [SerializeField] int maxHealth;
    private int health;
    private Rigidbody2D rb;

    public float speed;
    private GameObject player;
 
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
        ChasePlayer();
        FacingDirectionFlip();
    }


    //método que hace que el enemigo siga al jugador por el mapa
    private void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    //método para que enemigo siempre mire en dirección al jugador mientras le persigue
    private void FacingDirectionFlip()
    {
        //si el enemigo está a la derecha del jugador.... 
        if (transform.position.x > player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

   

    }
}
