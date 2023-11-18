using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class LevelSceneChanger : MonoBehaviour
{
    [SerializeField] public int indexNextScene; //index in build of scene you wanna go to

    /* If player enters area trigger (collider), move game to another scene
     * @param - collisionDetected: corresponde al objeto del collider que ha entrado en el area trigger collider
    */
    private void OnTriggerEnter2D(Collider2D collisionDetected)
    {
        //Comprobar si collisionDetected es el player
        if(collisionDetected.tag == "Player")
        {
            SceneController.cambiarEscena(indexNextScene);
        }
    }
}
