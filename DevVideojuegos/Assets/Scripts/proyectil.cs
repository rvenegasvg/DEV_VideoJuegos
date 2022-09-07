using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public Rigidbody balaPrefab;
    public Transform salidaProyectil;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
           Instantiate(balaPrefab, salidaProyectil.position, salidaProyectil.rotation);
            
        }

    }

}

