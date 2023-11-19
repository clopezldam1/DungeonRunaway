using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BatEnemy
{
    public class BatWaitTrigger : MonoBehaviour
    {
        public float speed;
        private GameObject player;
        public bool chase = false;
        public Transform startingPoint;

        // Start is called before the first frame update
        void Start()
        {
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

        /**método que hace que el enemigo siga al jugador por el mapa**/
        private void ChasePlayer()
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, player.transform.position) <= 0.5f)
            {
                //enemy attacks here bc its within reach
            }
            else
            {
                //reset variables
            }
        }

        /**método para que enemigo siempre mire en dirección al jugador mientras le persigue**/
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

        /**método que hace que enemigo se de la vuelta y regrese a su posicion original cuando jugador no está dentro de su rango de ataque**/
        private void ReturnToStartPos()
        {
            transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);

        }
    }
}