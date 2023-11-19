using BatEnemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallToDeath : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //quitar toda la vida y cambiar escena a "You died" screen
            Jugador player = collision.GetComponent<Jugador>();
            player.TakeDamage(GetComponent<Jugador>().maxHealth);
        }
    }
}
