using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarinstruccion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            singleton.current.maxSegundos = 10;
            singleton.current.LanzarCorrutina();
        }
    }
}
