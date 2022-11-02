using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour
{

    public Light light;

    public int factor = 1;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            light.spotAngle = light.spotAngle + factor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            light.spotAngle = light.spotAngle - factor * Time.deltaTime;
        }

        light.intensity = Mathf.PingPong(Time.time * factor, 4);
    }
}
