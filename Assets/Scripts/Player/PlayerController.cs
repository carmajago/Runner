using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidad;
    public float fuerzaSalto;
    public Vector2 velocidadLimite;
    [Range(-1, 1)]
    public int direccion = 1;
    private Rigidbody2D rb2D;
    private Transform tr;
    private ControladorSalto controladorSalto;
    private bool banderaSalto;
    private bool isGround;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        controladorSalto = GetComponent<ControladorSalto>();
    }



    private void Update()
    {
        moverPlayer();

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began && controladorSalto.isSuelo)
            {
                saltar();
            }

        }

        if ((Input.GetKeyDown("space")) && controladorSalto.isSuelo) /////////ojooooooooo
        {
            saltar();
        }

    }

    void saltar()
    {
        rb2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }


    private void moverPlayer()
    {
       
        tr.Translate(Vector2.right * velocidad *0.02f* direccion);
        // rb2D.velocity = Vector2.right * velocidad * Time.deltaTime * 10f;
    }


}
