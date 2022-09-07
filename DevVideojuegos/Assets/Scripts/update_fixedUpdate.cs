using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update_fixedUpdate : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("hola soy el update "+Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("hola soy el fixed update "+Time.deltaTime);
    }
}
