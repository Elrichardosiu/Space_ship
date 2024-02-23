using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
        void Update()
        {
            if (Input.GetButton("Fire1"))
            {
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;
                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * BalaVelocidad );
                Destroy(BalaTemporal, 5.0f);
            }

        }
}
