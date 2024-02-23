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
       seguirjugador = Physics.CheckSphere(transform.position, rangodeAlerta, (int)capadeljugador); 

        if(seguirjugador == true)
        {
            transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), velocidad);

        }
        transform.LookAt(jugador);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, jugador.position.y, jugador.position.z), velocidad);
    }
}
