using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BatEnemy
{
    public class BatFollow : MonoBehaviour
    {
        [SerializeField] public float speed;
        [SerializeField] public int damage;
        public bool chase = true;

        public void Start()
        {
            Bat.speed = speed;
            Bat.chase = chase;
            Bat.damage = damage;
        }


      
    }
}
