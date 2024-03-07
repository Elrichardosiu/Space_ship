using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiendo_adelante_eterno : MonoBehaviour
{
    public float Movimientoejex;
    public float Movimientoejey;
    public float Movimientoejez;
    public float speedH;
    public float speedV;
    float yaw;
    float pitch;
    float desacelerar = 0.1f;
    float acelerar = 0.1f;

    public float velocidad = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimientoejex = -velocidad * Time.deltaTime * 100;
        Movimientoejey = Input.GetAxis("Vertical") * Time.deltaTime * velocidad * 100;

        transform.Translate(Movimientoejex, Movimientoejey, Movimientoejez);

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedH * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0.0f, yaw, pitch);

        if (velocidad < 2.0f && Input.GetKeyDown("q"))
        {
            Debug.Log("acelera");
            velocidad= velocidad + acelerar;
            transform.Rotate(0.0f, 0.0f, 0.0f);
        }
        else if (velocidad >= 0.1f && Input.GetKeyDown("e"))
        {
            Debug.Log("disminuye");
            velocidad = velocidad - desacelerar;
            transform.Rotate(0.0f, 0.0f, 0.0f);
        }
       /* if(Input.GetKeyDown("w"))
        {
            transform.Rotate(0.0f, 0.0f, 90.0f);
        }
        else if (Input.GetKeyDown("s"))
        {
            transform.Rotate(0.0f, 0.0f, -90.0f);
        }*/
    }
}
