using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BatEnemy;

public class BatAttack : MonoBehaviour
{
    [SerializeField] Bat bat;
    [SerializeField] Jugador player;
    public void onTriggerEnter2D(Collider2D collision)
    {
        Jugador jugador = collision.GetComponent<Jugador>();
        if (jugador != null && jugador.tag.Equals("Player"))
        {
          
            //int damage = gameObject.GetComponentInParent<Bat>().getDamage();

            jugador.TakeDamage(1);
            //bat.attack();
        }
    }
   
}
