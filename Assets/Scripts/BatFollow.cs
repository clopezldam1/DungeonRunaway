using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bat
{
    public class BatFollow : MonoBehaviour
    {
        private Bat bat; 
        public float speed;
        private GameObject player;

        // Start is called before the first frame update
        void Start()
        {
            bat = new Bat();
       
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            ChasePlayer();
            FacingDirectionFlip();
        }


        //m�todo que hace que el enemigo siga al jugador por el mapa
        private void ChasePlayer()
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }

        //m�todo para que enemigo siempre mire en direcci�n al jugador mientras le persigue
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
    }
}
