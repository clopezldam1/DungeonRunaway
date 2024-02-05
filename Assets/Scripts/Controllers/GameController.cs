using UnityEngine;
using UnityEngine.UI;


public class ControladorJuego : MonoBehaviour
{
    [SerializeField]  Image healthbar;
    [SerializeField]  Sprite[] healthbarSprites;
    [SerializeField]  Jugador player;

    // Start is called before the first frame update
    void Start()
    {
        //change healthbar if player took damage
        healthbar.sprite = healthbarSprites[player.health];
    }

    // Update is called once per frame
    void Update()
    {
        if (player.health >= 0)
        {
            healthbar.sprite = healthbarSprites[player.health];
        }
    }
}
