using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;


public class ControladorJuego : MonoBehaviour
{
    [SerializeField]  Image healthbar;
    [SerializeField]  Sprite[] healthbarSprites;
    [SerializeField]  Jugador player;
    [SerializeField] GameObject hurtScreen;

    // Start is called before the first frame update
    void Start()
    {
         healthbar.sprite = healthbarSprites[player.health];
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.sprite = healthbarSprites[player.health];
        
        if (player.isHurt)
        {
           // healthLoss();//change healthbar if taken damage
            hurtScreen.SetActive(true);
        }
        else
        {
            hurtScreen.SetActive(false);
        }
    }

    //a este metodo se le llama desde jugador cuando pierde vida
    public void healthLoss() {
        healthbar.sprite = healthbarSprites[player.health];
    }
}
