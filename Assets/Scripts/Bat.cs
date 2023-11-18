using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bat { 
    public class Bat : MonoBehaviour
    {
        [SerializeField] public int maxHealth;
        public int health;
        public Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
          
           rb = GetComponent<Rigidbody2D>();
            health = maxHealth;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

    }
}