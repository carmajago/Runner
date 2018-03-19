using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeJuego : MonoBehaviour
{

    public Vector2 spawn;
    public bool playGame;

    EditorController editor;
    PlayerController playerController;
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        editor = GetComponent<EditorController>();
        editor.enabled = true;
        playerController.enabled = false;
        spawn = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {


        if (playerController.enabled)
        {
            player.transform.position = spawn;
        }
        else
        {

            spawn = player.transform.position;
            
        }
        playerController.enabled = !playerController.enabled;
        editor.enabled = !editor.enabled;
        playGame = playerController.enabled;
    }
}
