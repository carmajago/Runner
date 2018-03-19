using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertirSentido : MonoBehaviour {

    public int direccion=0;
    private PlayerController playerController = null;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            if (playerController == null)
            {
                playerController = collision.GetComponent<PlayerController>();
            }
            if (direccion == 0)
            {
                direccion = playerController.direccion * -1;
            }
            playerController.direccion =direccion ;
        }   
    }
  
}
