using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciar : MonoBehaviour
{
    public Rigidbody caja;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(caja);
        }
    }
}
