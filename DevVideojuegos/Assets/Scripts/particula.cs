using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particula : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public bool emision;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (particleSystem.isEmitting)
            {
                particleSystem.Stop();
                Debug.Log("se han detenido las particulas");
                emision = false;
            }
            else
            {
                particleSystem.Play();
                Debug.Log("se estan emitiendo particulas");
                emision = true;
            }
        }
    }
}
