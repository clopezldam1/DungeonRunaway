using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class VueloDragonEndLevel : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    float vertical;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 velocidad = rb.velocity;
        velocidad.y = vertical * speed * 7;
        velocidad.x = horizontal * speed * 5;
        rb.velocity = velocidad;

        if (rb.position.y < 500) { 
            //cambiar escena a "You died" screen
        }

    }
}
