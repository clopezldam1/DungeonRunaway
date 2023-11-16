using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class nextSkinMainMenu : MonoBehaviour
{
    [SerializeField] private Image imagen;
    [SerializeField] private Button next;
    [SerializeField] private Button prev;
    [SerializeField] private TextMeshProUGUI nomDragon;

    private Canvas canvas;
    private Sprite skin;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        skin = canvas.GetComponentInChildren<Image>().sprite; //we get the current skin 
        imagen = canvas.GetComponentInChildren<Image>();
       
    }

    public void nextSkin()
    {

        nomDragon.text = "aaaa";
        nomDragon.text = skin.GetSpriteID().ToString(); //esto peta

        nomDragon.text = "bbbbb"; //aqui no llega

        // imagen.sprite = Image().sprite("Assets/Sprites/Dragon1/Attack_017.png");
    }

    public void previousSkin()
    {

        imagen.sprite = skin;
    }

    public void confirmSelect()
    {

    }
}
