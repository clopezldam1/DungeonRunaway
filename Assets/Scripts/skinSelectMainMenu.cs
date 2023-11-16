using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextSkinMainMenu : MonoBehaviour
{
    public Sprite skin;
    public Image imagen;
    public Canvas canvas;
    public Button next;
    public Button prev;

 



    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        skin = canvas.GetComponentInChildren<Image>().sprite; //we get the current skin 
        imagen = canvas.GetComponentInChildren<Image>();
    }

    public void nextSkin()
    {
        
       // imagen.sprite = Image().sprite("Assets/Sprites/Dragon1/Attack_017.png");
    }

    public void previousSkin()
    {

        imagen.sprite = skin;
    }
}
