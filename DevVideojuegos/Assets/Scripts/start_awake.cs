using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_awake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola este es el start");
    }

    private void Awake()
    {
        Debug.Log("hola esto es el awake");
    }

    private void OnEnable()
    {
        Debug.Log("hola soy en onEnable");
    }

}
