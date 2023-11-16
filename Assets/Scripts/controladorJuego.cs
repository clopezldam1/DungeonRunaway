using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;


public class controladorJuego : MonoBehaviour
{

    [SerializeField]  Image healthbar;
    [SerializeField]  Sprite[] healthbarSprites;
    [SerializeField]  player jugador;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = jugador.health;
        healthbar.sprite = healthbarSprites[health];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //a este metodo se le llama desde jugador cuando pierde vida
    public void healthLoss() {
        health--;
        healthbar.sprite = healthbarSprites[health];
    }
}
