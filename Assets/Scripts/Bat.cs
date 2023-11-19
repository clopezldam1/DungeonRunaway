
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BatEnemy { 
    public class Bat : MonoBehaviour
    {
        [SerializeField] public int maxHealth;
        private int health;
        private Rigidbody2D rb;
        [SerializeField] GameObject blood;
        private Jugador player;
        public static bool chase;
        public static float speed;
        public static int damage;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            health = maxHealth;
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>();
        }

        // Update is called once per frame
        void Update()
        {
            if (chase)
            {
                ChasePlayer();
                FacingDirectionFlip();
            }

        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            if(health <= 0)
            {
                Instantiate(blood);
                Destroy(gameObject);
            }
        }
        public void attack()
        {
            player.TakeDamage(damage);
        }

        /**m�todo que hace que el enemigo siga al jugador por el mapa**/
        private void ChasePlayer()
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        /**m�todo para que enemigo siempre mire en direcci�n al jugador mientras le persigue**/
        private void FacingDirectionFlip()
        {
            //si el enemigo est� a la derecha del jugador.... 
            if (transform.position.x > player.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
 
        public int getDamage()
        {
            return damage;
        }

    }
}