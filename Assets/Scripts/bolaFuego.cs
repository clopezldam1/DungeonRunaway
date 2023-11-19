using BatEnemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class BolaFuego : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    [SerializeField] private GameObject blood;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bat bat = collision.GetComponent<Bat>();
        if (bat != null) 
        {
            bat.TakeDamage(1);
            Instantiate(blood, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
