using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelectMainMenu : MonoBehaviour
{
    [SerializeField] private Image imagen;
    [SerializeField] private Button next;
    [SerializeField] private Button prev;
    [SerializeField] private TextMeshProUGUI nomDragon;

    [SerializeField] Sprite[] sprites;

    private int currentSkin; //index del sprite en sprites[]
    private string nombreSkin;


    // Start is called before the first frame update
    void Start()
    {
        currentSkin = 0;
        imagen.sprite = sprites[0];
        nombreSkin = "Green Dragon";
        nomDragon.text = nombreSkin;
    }

    public void nextSkin()
    {
        switch (currentSkin) {
            case 0: imagen.sprite = sprites[1]; currentSkin = 1; nombreSkin = "Black Dragon"; break;   
            case 1: imagen.sprite = sprites[2]; currentSkin = 2; nombreSkin = "Red Dragon"; break;
            case 2: imagen.sprite = sprites[0]; currentSkin = 0; nombreSkin = "Green Dragon"; break;
        }
        nomDragon.text = nombreSkin;
    }

    public void previousSkin()
    {
        switch (currentSkin)
        {
            case 0: imagen.sprite = sprites[2]; currentSkin = 2; nombreSkin = "Red Dragon"; break;
            case 1: imagen.sprite = sprites[0]; currentSkin = 0; nombreSkin = "Green Dragon"; break;
            case 2: imagen.sprite = sprites[1]; currentSkin = 1; nombreSkin = "Black Dragon"; break;
        }
        nomDragon.text = nombreSkin;
    }

    public void confirmSelect()
    {
        //enviar a level1 la info del sprite que debe utilizar
    }
}
