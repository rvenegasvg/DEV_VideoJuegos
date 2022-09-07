using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render : MonoBehaviour
{
    public bool activado = true;
    public GameObject gameObject;


    void Update()
    {
       
        if (activado)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("activando render");
        }
        else
        {
           // gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("desactivando render");
        }
        
    }
}
