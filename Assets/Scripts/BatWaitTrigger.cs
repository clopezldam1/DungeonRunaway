
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using BatEnemy;


namespace BatEnemy
{
    public class BatWaitTrigger : MonoBehaviour
    {
        [SerializeField] float speed;
        public Transform startingPoint;
        public bool chase;
        [SerializeField] public int damage;

        public void Start()
        {
            Bat.speed = speed;
            chase = Bat.chase;
            Bat.damage = damage;
        }

        // Update is called once per frame
        void Update()
        {
            if (!Bat.chase)
            {
                //go to starting position
                ReturnToStartPos();
            }

        }

        /**método que hace que enemigo se de la vuelta y regrese a su posicion original cuando jugador no está dentro de su rango de ataque**/
        private void ReturnToStartPos()
        {
            transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);

        }
    }
}