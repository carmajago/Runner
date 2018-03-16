using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinController : MonoBehaviour {

    public float fuerzaImpulso=10;
    public float tiempoEspera=0.1f;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.tag== "Personajes" || collision.tag == "Player")
        {
 
            StartCoroutine(impulsar(collision.GetComponent<Rigidbody2D>()));
        }
    }

    

    IEnumerator impulsar(Rigidbody2D rb2D)
    {
        yield return new WaitForSeconds(tiempoEspera);
        Debug.Log("entra:");
        rb2D.AddForce(Vector2.up * fuerzaImpulso,ForceMode2D.Impulse);

    }
}
