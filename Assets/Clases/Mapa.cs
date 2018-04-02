using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public class Mapa  {
    public string nombre;
    [SerializeField]
    public List<Objeto>  diccionario;

    public Mapa()
    {
        nombre = "Mapita";
        diccionario = new List<Objeto>();
    }
}
