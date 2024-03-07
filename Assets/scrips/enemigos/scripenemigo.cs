using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripenemigo : MonoBehaviour
{   
    public float capadeljugador;
    public float rangodeAlerta;
    public Transform jugador;
   public bool seguirjugador;
    public float velocidad;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        transform.LookAt(jugador);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, jugador.position.y, jugador.position.z), velocidad);


    }
}
