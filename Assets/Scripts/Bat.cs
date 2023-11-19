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

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            health = maxHealth;
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
    }
}