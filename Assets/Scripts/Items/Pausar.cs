using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour {


    private PlayerController playerController=null;
    private int direccionActual;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (playerController == null)
            {
                playerController = collision.GetComponent<PlayerController>();
            }
            direccionActual = playerController.direccion;
            playerController.direccion = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (playerController == null)
            {
                playerController = collision.GetComponent<PlayerController>();
            }

            playerController.direccion = direccionActual;
        }
    }

}
