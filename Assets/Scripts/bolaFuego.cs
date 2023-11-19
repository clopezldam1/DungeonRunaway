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

        Timer();
    }

    IEnumerator Timer()
    {;
        //despues de disparar, se destruye al pasar 4secs
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bat bat = collision.GetComponent<Bat>();
        if (bat != null) 
        {
            bat.TakeDamage(1);
            Instantiate(blood, transform.position, transform.rotation);
        }
        Timer();
    }
}
